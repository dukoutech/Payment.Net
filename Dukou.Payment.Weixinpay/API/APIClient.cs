using Common.Logging;
using Dukou.Payment.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Dukou.Payment.Weixinpay.API
{
    public class APIClient
    {
        private static ILog logger = LogManager.GetLogger("Weixinpay");

        private static string pay_unifiedorder_url = "https://api.mch.weixin.qq.com/pay/unifiedorder";

        private static string pay_orderquery_url = "https://api.mch.weixin.qq.com/pay/orderquery";

        /// <summary>
        /// 统一下单
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static UnifiedOrderResult UnifiedOrder(UnifiedOrderParam param)
        {
            var request = HttpUtil.Create(pay_unifiedorder_url);

            var xml = request.PostXml(param.ToXml());

            logger.Info($"微信支付统一下单返回结果:{xml}");

            UnifiedOrderResult result = new UnifiedOrderResult();
            result.LoadXml(xml);

            return result;
        }

        /// <summary>
        /// 查询订单
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static OrderQueryResult OrderQuery(OrderQueryParam param)
        {
            var request = HttpUtil.Create(pay_orderquery_url);

            var xml = request.PostXml(param.ToXml());

            logger.Info($"微信支付查询订单返回结果:{xml}");

            OrderQueryResult result = new OrderQueryResult();
            result.LoadXml(xml);

            return result;
        }

        /// <summary>
        /// 接收支付结果通知
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static PayNotifyResult ReceivePayNotifyResult(HttpRequestBase request)
        {
            using (var reader = new StreamReader(request.InputStream))
            {
                var xml = reader.ReadToEnd();

                logger.Info($"支付结果通知:{xml}");

                PayNotifyResult result = new PayNotifyResult();
                result.LoadXml(xml);

                return result;
            } 
        }
    }
}
