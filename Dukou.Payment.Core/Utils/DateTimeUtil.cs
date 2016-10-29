using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Payment.Utils
{
    public class DateTimeUtil
    {
        public static string HHmmss(DateTime dt)
        {
            return dt.ToString("HHmmss");
        }

        public static string yyyyMMdd(DateTime dt)
        {
            return dt.ToString("yyyyMMdd");
        }

        public static string yyyyMMddHHmmss(DateTime dt)
        {
            return dt.ToString("yyyyMMddHHmmss");
        }
    }
}
