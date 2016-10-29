using Dukou.Payment.PO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou.Payment.Dao
{
    public interface IPaymentOrderDao
    {
        PaymentOrder FindByPaymentAppIdAndPaymentOrderNumber(string paymentAppId, string paymentOrderNumber);
    }
}
