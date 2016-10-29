using Dukou.Payment.PO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Payment.Weixinpay.SwiftPass.PO
{
    public class WeixinpayBySwiftPassApp : PaymentApp
    {
        /// <summary>
        /// 公众账号ID|企业号corpid
        /// </summary>
        public virtual string AppId { get; set; }

        /// <summary>
        /// 公众号应用密钥
        /// </summary>
        public virtual string AppSecret { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        public virtual string MchId { get; set; }

        /// <summary>
        /// 通知地址
        /// </summary>
        public virtual string NotifyUrl { get; set; }

        /// <summary>
        /// 签名KEY
        /// </summary>
        public virtual string SignKey { get; set; }
    }
}
