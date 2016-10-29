using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Payment.Weixinpay.API
{
    /// <summary>
    /// 交易类型
    /// </summary>
    public class TradeTypes
    {
        /// <summary>
        /// APP支付
        /// </summary>
        public static string APP = "APP";

        /// <summary>
        /// 公众号支付
        /// </summary>
        public static string JSAPI = "JSAPI";

        /// <summary>
        /// 刷卡支付
        /// </summary>
        public static string MICROPAY = "MICROPAY";

        /// <summary>
        /// 原生扫码支付
        /// </summary>
        public static string NATIVE = "NATIVE";
   }
}
