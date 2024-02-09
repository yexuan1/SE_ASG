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

        private string cardName { get; set; }
        private int cardNumber { get; set; }
        private int cvc { get; set; }

        public PaymentMethod(string cardname, int cardNumber, int cvc)
        {
            this.cardName = cardname;
            this.cardNumber = cardNumber;
            this.cvc = cvc;
        }

        public bool InitiateTransaction(PaymentMethod paymentmethod)
        {
            //Implementation
            return true;
        }

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
