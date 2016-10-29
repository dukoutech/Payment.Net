using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Payment.PO
{
    /// <summary>
    /// 支付应用类型
    /// </summary>
    public enum PaymentType
    {
        /// <summary>
        /// 支付宝
        /// </summary>
        Alipay,

        /// <summary>
        /// 银联电子支付
        /// </summary>
        Chinapay,

        /// <summary>
        /// 银联支付
        /// </summary>
        Unionpay,

        /// <summary>
        /// 微信支付
        /// </summary>
        Weixinpay,

        /// <summary>
        /// 威富通
        /// </summary>
        WeixinpayBySwiftPass
    }
}
