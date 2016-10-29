using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Payment.Weixinpay.API
{
    public class OrderQueryParam : APIData
    {
        public OrderQueryParam()
        {
            SetDataType("appid", APIDataTypes.STRING);
            SetDataType("mch_id", APIDataTypes.STRING);
            SetDataType("transaction_id", APIDataTypes.STRING);
            SetDataType("out_trade_no", APIDataTypes.STRING);
            SetDataType("nonce_str", APIDataTypes.STRING);
            SetDataType("sign", APIDataTypes.STRING);
        }

        /// <summary>
        /// 公众账号ID
        /// </summary>
        public string appid { get { return this["appid"]; } set { this["appid"] = value; } }

        /// <summary>
        /// 商户号
        /// </summary>
        public string mch_id { get { return this["mch_id"]; } set { this["mch_id"] = value; } }

        /// <summary>
        /// 微信订单号
        /// </summary>
        public string transaction_id { get { return this["transaction_id"]; } set { this["transaction_id"] = value; } }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string out_trade_no { get { return this["out_trade_no"]; } set { this["out_trade_no"] = value; } }

        /// <summary>
        /// 随机字符串
        /// </summary>
        public string nonce_str { get { return this["nonce_str"]; } set { this["nonce_str"] = value; } }

        /// <summary>
        /// 签名
        /// </summary>
        public string sign { get { return this["sign"]; } set { this["sign"] = value; } }

    }
}
