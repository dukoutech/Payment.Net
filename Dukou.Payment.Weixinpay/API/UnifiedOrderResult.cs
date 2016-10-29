using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Payment.Weixinpay.API
{
    public class UnifiedOrderResult : APIData
    {
        public UnifiedOrderResult()
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
            SetDataType("trade_type", APIDataTypes.STRING);
            SetDataType("prepay_id", APIDataTypes.STRING);
            SetDataType("code_url", APIDataTypes.STRING);
        }

        public string return_code { get { return this["return_code"]; } set { this["return_code"] = value; } }

        public string return_msg { get { return this["return_msg"]; } set { this["return_msg"] = value; } }

        #region return_code 为 SUCCESS 有值

        public string appid { get { return this["appid"]; } set { this["appid"] = value; } }

        public string mch_id { get { return this["mch_id"]; } set { this["mch_id"] = value; } }

        public string device_info { get { return this["device_info"]; } set { this["device_info"] = value; } }

        public string nonce_str { get { return this["nonce_str"]; } set { this["nonce_str"] = value; } }

        public string sign { get { return this["sign"]; } set { this["sign"] = value; } }

        public string result_code { get { return this["result_code"]; } set { this["result_code"] = value; } }

        public string err_code { get { return this["err_code"]; } set { this["err_code"] = value; } }

        public string err_code_des { get { return this["err_code_des"]; } set { this["err_code_des"] = value; } }

        #endregion

        #region return_code 和 result_code 都为 SUCCESS 有值

        public string trade_type { get { return this["trade_type"]; } set { this["trade_type"] = value; } }

        public string prepay_id { get { return this["prepay_id"]; } set { this["prepay_id"] = value; } }

        public string code_url { get { return this["code_url"]; } set { this["code_url"] = value; } }

        #endregion
    }
}
