using Common.Logging;
using Dukou.Payment.Dao;
using Dukou.Payment.PO;
using Dukou.Payment.Weixinpay.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dukou.Payment.Web.Controllers
{
    public class WeixinpayController : Controller
    {
        private static ILog logger = LogManager.GetLogger<WeixinpayController>();

        public IPaymentOrderDao PaymentOrderDao { get; set; }

        public ActionResult BackNotify()
        {
            var payNotifyResponseResult = new PayNotifyResponseResult();
            try
            {
                var payNotifyResult = APIClient.ReceivePayNotifyResult(this.Request);
                if (payNotifyResult.CheckSign(string.Empty))
                {
                    var paymentOrder = PaymentOrderDao.FindByPaymentAppIdAndPaymentOrderNumber(string.Empty, payNotifyResult.out_trade_no);
                    if (paymentOrder == null)
                    {
                        payNotifyResponseResult.return_code = ReturnCodes.FAIL;
                        payNotifyResponseResult.return_msg = "商户单号不存在";
                    }
                    else if (paymentOrder.State == PaymentOrderState.WaittingPay)
                    {
                        paymentOrder.State = PaymentOrderState.Paid;
                        paymentOrder.PaymentTime = DateTime.Now;
                    }
                }
                else
                {
                    payNotifyResponseResult.return_code = ReturnCodes.FAIL;
                    payNotifyResponseResult.return_msg = "签名失败";
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex);

                payNotifyResponseResult.return_code = ReturnCodes.FAIL;
                payNotifyResponseResult.return_msg = "系统异常";
            }

            return Content(payNotifyResponseResult.ToXml());
        }
    }
}