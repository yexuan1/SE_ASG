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

            Console.WriteLine("---------------Payment Methods------------");
            Console.WriteLine("   1. Saved card *********9876");
            Console.WriteLine("   2. Add new payment method (Visa/Master/PayPal)");
            Console.WriteLine();
            Console.WriteLine("Please select a payment method:");
        }
    }
}
