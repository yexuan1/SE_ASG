﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_ASG.Models
{
    internal class CreditCard : PaymentMethod
    {
        public CreditCard(string cardname, int cardnumber, int cvc) : base(cardname, cardnumber, cvc)
        {
            //Implementation
        }
    }
}
