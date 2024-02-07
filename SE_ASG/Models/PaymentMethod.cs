using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_ASG.Models
{
    public class PaymentMethod
    {
        private string paymentType {  get; set; }

        public PaymentMethod(string PaymentType)
        {
            paymentType = PaymentType;
        }
    }
}
