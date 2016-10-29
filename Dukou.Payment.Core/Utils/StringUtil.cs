using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Payment.Utils
{
    public static class StringUtil
    {
        static DateTime UTC1970 = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

        public static string GenerateNonceStr()
        {
            return Guid.NewGuid().ToString("N");
        }

        public static string GenerateTimeStamp()
        {
            return Convert.ToInt64((DateTime.UtcNow - UTC1970).TotalSeconds).ToString();
        }

        public static string ToMD5(this string source)
        {
            var md5 = MD5.Create();
            var byteArray = md5.ComputeHash(Encoding.UTF8.GetBytes(source));
            var strBuilder = new StringBuilder();
            foreach (byte b in byteArray)
            {
                strBuilder.Append(b.ToString("X2"));
            }

            return strBuilder.ToString();
        }
    }
}
