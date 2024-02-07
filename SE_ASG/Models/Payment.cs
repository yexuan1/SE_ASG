using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_ASG.Models
{
    public class Payment
    {
        private double amount {  get; set; }

        private DateOnly paymentDate {  get; set; }

        public Payment(double Amount, DateOnly PaymentDate)
        {
            amount = Amount;
            paymentDate = PaymentDate;
        }
    }
}
