using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SE_ASG.Models
{
    public class ParkingRecord
    {
        private int parkingNumber { get; set; }
        private DateTime entryDateTime { get; set; }
        private DateTime exitDateTime { get; set; }
        private double amountCharged { get; set; }
        private string vehicleType { get; set; }
    }
}
