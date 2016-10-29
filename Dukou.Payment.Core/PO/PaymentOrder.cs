using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Payment.PO
{
    /// <summary>
    /// 支付订单
    /// </summary>
    public class PaymentOrder
    {
        /// <summary>
        /// 支付订单Id
        /// </summary>
        public virtual long Id { get; set; }

        /// <summary>
        /// 支付应用
        /// </summary>
        public virtual PaymentApp PaymentApp { get; set; }

        /// <summary>
        /// 支付订单号
        /// </summary>
        public virtual string PaymentOrderNumber { get; set; }

        /// <summary>
        /// 支付订单金额
        /// </summary>
        public virtual decimal PaymentOrderAmount { get; set; }

        /// <summary>
        /// 支付订单状态
        /// </summary>
        public virtual PaymentOrderState State { get; set; }

        /// <summary>
        /// 支付凭证号
        /// </summary>
        public virtual string PaymentNumber { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        public virtual decimal? PaymentAmount { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        public virtual DateTime? PaymentTime { get; set; }

        /// <summary>
        /// 通知时间
        /// </summary>
        public virtual DateTime? NotifyTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime CreateTime { get; set; }
    }
}
