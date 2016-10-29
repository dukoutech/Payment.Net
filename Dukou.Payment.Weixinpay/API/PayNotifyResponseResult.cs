using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Payment.Weixinpay.API
{
    public class PayNotifyResponseResult : APIData
    {
        public PayNotifyResponseResult()
        {
            SetDataType("return_code", APIDataTypes.STRING);
            SetDataType("return_msg", APIDataTypes.STRING);

            return_code = ReturnCodes.SUCCESS;
            return_msg = "OK";
        }

        /// <summary>
        /// 返回状态码
        /// </summary>
        public string return_code { get { return this["return_code"]; } set { this["return_code"] = value; } }

        /// <summary>
        /// 返回信息
        /// </summary>
        public string return_msg { get { return this["return_msg"]; } set { this["return_msg"] = value; } }

    }
}
