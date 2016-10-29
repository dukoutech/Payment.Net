using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Payment.Weixinpay.API
{
    /// <summary>
    /// 统一下单参数
    /// </summary>
    public class UnifiedOrderParam : APIData
    {
        public UnifiedOrderParam()
        {
            SetDataType("appid", APIDataTypes.STRING);
            SetDataType("mch_id", APIDataTypes.STRING);
            SetDataType("device_info", APIDataTypes.STRING);
            SetDataType("nonce_str", APIDataTypes.STRING);
            SetDataType("sign", APIDataTypes.STRING);
            SetDataType("body", APIDataTypes.STRING);
            SetDataType("detail", APIDataTypes.STRING);
            SetDataType("attach", APIDataTypes.STRING);
            SetDataType("out_trade_no", APIDataTypes.STRING);
            SetDataType("fee_type", APIDataTypes.STRING);
            SetDataType("total_fee", APIDataTypes.INT);
            SetDataType("spbill_create_ip", APIDataTypes.STRING);
            SetDataType("time_start", APIDataTypes.STRING);
            SetDataType("time_expire", APIDataTypes.STRING);
            SetDataType("goods_tag", APIDataTypes.STRING);
            SetDataType("notify_url", APIDataTypes.STRING);
            SetDataType("trade_type", APIDataTypes.STRING);
            SetDataType("product_id", APIDataTypes.STRING);
            SetDataType("limit_pay", APIDataTypes.STRING);
            SetDataType("openid", APIDataTypes.STRING);
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
        /// 设备号
        /// </summary>
        public string device_info { get { return this["device_info"]; } set { this["device_info"] = value; } }

        /// <summary>
        /// 随机字符串
        /// </summary>
        public string nonce_str { get { return this["nonce_str"]; } set { this["nonce_str"] = value; } }

        /// <summary>
        /// 签名
        /// </summary>
        public string sign { get { return this["sign"]; } set { this["sign"] = value; } }

        /// <summary>
        /// 商品描述
        /// </summary>
        public string body { get { return this["body"]; } set { this["body"] = value; } }

        /// <summary>
        /// 商品详情
        /// </summary>
        public string detail { get { return this["detail"]; } set { this["detail"] = value; } }

        /// <summary>
        /// 附加数据
        /// </summary>
        public string attach { get { return this["attach"]; } set { this["attach"] = value; } }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string out_trade_no { get { return this["out_trade_no"]; } set { this["out_trade_no"] = value; } }

        /// <summary>
        /// 货币类型
        /// </summary>
        public string fee_type { get { return this["fee_type"]; } set { this["fee_type"] = value; } }

        /// <summary>
        /// 总金额
        /// </summary>
        public string total_fee { get { return this["total_fee"]; } set { this["total_fee"] = value; } }

        /// <summary>
        /// 终端IP
        /// </summary>
        public string spbill_create_ip { get { return this["spbill_create_ip"]; } set { this["spbill_create_ip"] = value; } }

        /// <summary>
        /// 交易起始时间
        /// </summary>
        public string time_start { get { return this["time_start"]; } set { this["time_start"] = value; } }

        /// <summary>
        /// 交易结束时间
        /// </summary>
        public string time_expire { get { return this["time_expire"]; } set { this["time_expire"] = value; } }

        /// <summary>
        /// 商品标记
        /// </summary>
        public string goods_tag { get { return this["goods_tag"]; } set { this["goods_tag"] = value; } }

        /// <summary>
        /// 通知地址
        /// </summary>
        public string notify_url { get { return this["notify_url"]; } set { this["notify_url"] = value; } }

        /// <summary>
        /// 交易类型
        /// </summary>
        public string trade_type { get { return this["trade_type"]; } set { this["trade_type"] = value; } }

        /// <summary>
        /// 商品ID
        /// </summary>
        public string product_id { get { return this["product_id"]; } set { this["product_id"] = value; } }

        /// <summary>
        /// 指定支付方式
        /// </summary>
        public string limit_pay { get { return this["limit_pay"]; } set { this["limit_pay"] = value; } }

        /// <summary>
        /// 用户标识
        /// </summary>
        public string openid { get { return this["openid"]; } set { this["openid"] = value; } }
    }
}
