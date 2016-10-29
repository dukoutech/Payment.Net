using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Payment.Weixinpay.API
{
    /// <summary>
    /// 支付结果
    /// </summary>
    public class PayNotifyResult : APIData
    {
        public PayNotifyResult()
        {
            SetDataType("return_code", APIDataTypes.STRING);
            SetDataType("return_msg", APIDataTypes.STRING);
            SetDataType("appid", APIDataTypes.STRING);
            SetDataType("mch_id", APIDataTypes.STRING);
            SetDataType("device_info", APIDataTypes.STRING);
            SetDataType("nonce_str", APIDataTypes.STRING);
            SetDataType("sign", APIDataTypes.STRING);
            SetDataType("result_code", APIDataTypes.STRING);
            SetDataType("err_code", APIDataTypes.STRING);
            SetDataType("err_code_des", APIDataTypes.STRING);
            SetDataType("openid", APIDataTypes.STRING);
            SetDataType("is_subscribe", APIDataTypes.STRING);
            SetDataType("trade_type", APIDataTypes.STRING);
            SetDataType("bank_type", APIDataTypes.STRING);
            SetDataType("total_fee", APIDataTypes.STRING);
            SetDataType("settlement_total_fee", APIDataTypes.STRING);
            SetDataType("fee_type", APIDataTypes.STRING);
            SetDataType("cash_fee", APIDataTypes.STRING);
            SetDataType("cash_fee_type", APIDataTypes.STRING);
            SetDataType("coupon_fee", APIDataTypes.STRING);
            SetDataType("coupon_count", APIDataTypes.STRING);
            SetDataType("coupon_type_$0", APIDataTypes.STRING);
            SetDataType("coupon_id_$0", APIDataTypes.STRING);
            SetDataType("coupon_fee_$0", APIDataTypes.INT);
            SetDataType("transaction_id", APIDataTypes.STRING);
            SetDataType("out_trade_no", APIDataTypes.STRING);
            SetDataType("attach", APIDataTypes.STRING);
            SetDataType("time_end", APIDataTypes.STRING);
        }

        /// <summary>
        /// 返回状态码
        /// </summary>
        public string return_code { get { return this["return_code"]; } set { this["return_code"] = value; } }

        /// <summary>
        /// 返回信息
        /// </summary>
        public string return_msg { get { return this["return_msg"]; } set { this["return_msg"] = value; } }

        #region return_code 为 SUCCESS 有值

        /// <summary>
        /// 公众账号ID
        /// </summary>
        public string appid { get { return this["appid"]; } set { this["appid"] = value; } }

        /// <summary>
        /// 商户号
        /// </summary>
        public string mch_id { get { return this["mch_id"]; } set { this["mch_id"] = value; } }

        public string device_info { get { return this["device_info"]; } set { this["device_info"] = value; } }

        public string nonce_str { get { return this["nonce_str"]; } set { this["nonce_str"] = value; } }

        public string sign { get { return this["sign"]; } set { this["sign"] = value; } }

        public string result_code { get { return this["result_code"]; } set { this["result_code"] = value; } }

        public string err_code { get { return this["err_code"]; } set { this["err_code"] = value; } }

        public string err_code_des { get { return this["err_code_des"]; } set { this["err_code_des"] = value; } }

        public string openid { get { return this["openid"]; } set { this["openid"] = value; } }

        public string is_subscribe { get { return this["is_subscribe"]; } set { this["is_subscribe"] = value; } }

        public string trade_type { get { return this["trade_type"]; } set { this["trade_type"] = value; } }

        public string bank_type { get { return this["bank_type"]; } set { this["bank_type"] = value; } }

        public string total_fee { get { return this["total_fee"]; } set { this["total_fee"] = value; } }

        public string settlement_total_fee { get { return this["settlement_total_fee"]; } set { this["settlement_total_fee"] = value; } }

        public string fee_type { get { return this["fee_type"]; } set { this["fee_type"] = value; } }

        public string cash_fee { get { return this["cash_fee"]; } set { this["cash_fee"] = value; } }

        public string cash_fee_type { get { return this["cash_fee_type"]; } set { this["cash_fee_type"] = value; } }

        public string coupon_fee { get { return this["coupon_fee"]; } set { this["coupon_fee"] = value; } }

        public string coupon_count { get { return this["coupon_count"]; } set { this["coupon_count"] = value; } }

        /// <summary>
        /// 代金券类型
        /// </summary>
        public string coupon_type_0 { get { return this["coupon_type_$0"]; } set { this["coupon_type_$0"] = value; } }

        /// <summary>
        /// 代金券ID
        /// </summary>
        public string coupon_id_0 { get { return this["coupon_id_$0"]; } set { this["coupon_id_$0"] = value; } }

        /// <summary>
        /// 单个代金券支付金额
        /// </summary>
        public string coupon_fee_0 { get { return this["coupon_fee_$0"]; } set { this["coupon_fee_$0"] = value; } }

        /// <summary>
        /// 微信支付订单号
        /// </summary>
        public string transaction_id { get { return this["transaction_id"]; } set { this["transaction_id"] = value; } }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string out_trade_no { get { return this["out_trade_no"]; } set { this["out_trade_no"] = value; } }

        /// <summary>
        /// 附加数据
        /// </summary>
        public string attach { get { return this["attach"]; } set { this["attach"] = value; } }

        /// <summary>
        /// 支付完成时间
        /// </summary>
        public string time_end { get { return this["time_end"]; } set { this["time_end"] = value; } }

        #endregion

    }
}
