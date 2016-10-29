using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Payment.PO
{
    /// <summary>
    /// 支付通知日志状态
    /// </summary>
    public enum PaymentNotifyLogState
    {
        /// <summary>
        /// 待通知
        /// </summary>
        WattingNotify = 1,

        /// <summary>
        /// 已通知
        /// </summary>
        Notified = 2,

        /// <summary>
        /// 大于最大通知次数
        /// </summary>
        GTMaxNotifyCount = 4
    }
}
