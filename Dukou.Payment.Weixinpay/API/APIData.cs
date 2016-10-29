using Dukou.Payment.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Dukou.Payment.Weixinpay.API
{
    /// <summary>
    /// 
    /// </summary>
    public class APIData
    {
        private static string SIGNKEY = "sign";

        private static ISet<string> NOSIGNKEYS = new HashSet<string>()
        {
            SIGNKEY
        };

        private IDictionary<string, string> DATATYPES = new Dictionary<string, string>() { { SIGNKEY, APIDataTypes.STRING } };

        private IDictionary<string, string> VALUES = new SortedDictionary<string, string>();

        protected string GetDataType(string key)
        {
            return DATATYPES[key];
        }

        protected void SetDataType(string key, string dataType)
        {
            DATATYPES[key] = dataType;
            VALUES[key] = string.Empty;
        }

        public string this[string key]
        {
            get
            {
                return VALUES[key];
            }
            set
            {
                VALUES[key] = value;
            }
        }

        public bool CheckSign(string key)
        {
            if (!VALUES.ContainsKey(SIGNKEY))
            {
                return false;
            }

            var sign = VALUES[SIGNKEY];

            Sign(key);

            return string.Equals(sign, VALUES[SIGNKEY]);
        }

        public void LoadXml(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            foreach (XmlNode item in doc.SelectSingleNode("xml").ChildNodes)
            {
                if (DATATYPES.ContainsKey(item.Name))
                {
                    this[item.Name] = item.InnerText;
                }
            }
        }

        public void Sign(string key)
        {
            VALUES[SIGNKEY] = $"{ToQueryString(NOSIGNKEYS)}&key={key}".ToMD5();
        }

        public string ToJson()
        {
            return $@"{{
{string.Join("\n,", Values().Select(x => $"\"{x.Key}\":{(DATATYPES[x.Key] == "string" ? $"\"{x.Value}\"" : "x.Value")}"))}
}}";
        }

        public string ToQueryString()
        {
            return string.Join("&", Values().Select(x => $"{x.Key}={x.Value}"));
        }

        public string ToQueryString(ISet<string> excludes)
        {
            return string.Join("&", Values().Where(x => !excludes.Contains(x.Key)).Select(x => $"{x.Key}={x.Value}"));
        }

        public string ToXml()
        {
            return $@"<xml>
{string.Join("\n", Values().Select(x => $"<{x.Key}>{(DATATYPES[x.Key] == "string" ? $"<![CDATA[{x.Value}]]>" : x.Value)}</{x.Key}>"))}
</xml>";
        }

        public IEnumerable<KeyValuePair<string, string>> Values()
        {
            return VALUES.Where(x => !string.IsNullOrEmpty(x.Value));
        }

    }
}
