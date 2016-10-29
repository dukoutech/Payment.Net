using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Payment.PO
{
    /// <summary>
    /// 支付应用
    /// </summary>
    public abstract class PaymentApp
    {
        public virtual string Id { get; set; }

        public virtual string PaymentAppName { get; set; }

        public virtual string PaymentAppKey { get; set; }

        public virtual string PaymentAppNotifyUrl { get; set; }

        public virtual PaymentType PaymentType { get; set; }
    }
}
