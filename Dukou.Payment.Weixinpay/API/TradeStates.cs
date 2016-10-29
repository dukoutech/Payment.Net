using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Payment.Weixinpay.API
{
    /// <summary>
    /// 交易状态
    /// </summary>
    public class TradeStates
    {
        /// <summary>
        /// 支付成功
        /// </summary>
        public static string SUCCESS = "SUCCESS";

        /// <summary>
        /// 转入退款
        /// </summary>
        public static string REFUND = "REFUND";

        /// <summary>
        /// 未支付
        /// </summary>
        public static string NOTPAY = "NOTPAY";

        /// <summary>
        /// 已关闭
        /// </summary>
        public static string CLOSED = "CLOSED";

        /// <summary>
        /// 已撤销（刷卡支付）
        /// </summary>
        public static string REVOKED = "REVOKED";

        /// <summary>
        /// 用户支付中
        /// </summary>
        public static string USERPAYING = "USERPAYING";

        /// <summary>
        /// 支付失败(其他原因，如银行返回失败)
        /// </summary>
        public static string PAYERROR = "PAYERROR";
    }
}
