using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Payment.PO
{
    /// <summary>
    /// 支付通知日志
    /// </summary>
    public class PaymentNotifyLog
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual long Id { get; set; }

        /// <summary>
        /// 支付订单Id
        /// </summary>
        public virtual long PaymentOrderId { get; set; }

        /// <summary>
        /// 通知地址
        /// </summary>
        public virtual string NotifyUrl { get; set; }

        /// <summary>
        /// 通知内容
        /// </summary>
        public virtual string NotifyContent { get; set; }

        /// <summary>
        /// 通知次数
        /// </summary>
        public virtual int NotifyCount { get; set; }

        /// <summary>
        /// 下一次通知时间
        /// </summary>
        public virtual DateTime NextNotifyTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public virtual PaymentNotifyLogState State { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime CreateTime { get; set; }
    }
}
