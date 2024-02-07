using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_ASG.Models
{
    public class ParkingCharge
    {
        private int uniqueParkingNumber { get; set; }

        private DateTime entryDateTime { get; set; }

        private DateTime exitDateTime {  get; set; }

        private double amount {  get; set; }

        public ParkingCharge()
        {

        }
    }
}
