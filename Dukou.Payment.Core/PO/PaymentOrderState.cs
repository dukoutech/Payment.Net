using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Payment.PO
{
    /// <summary>
    /// 支付订单状态
    /// </summary>
    public enum PaymentOrderState
    {
        /// <summary>
        /// 待支付
        /// </summary>
        WaittingPay = 1,

        /// <summary>
        /// 已支付
        /// </summary>
        Paid = 2,

        /// <summary>
        /// 已通知
        /// </summary>
        Notified = 4
    }
}
