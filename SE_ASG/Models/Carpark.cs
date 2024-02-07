using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_ASG.Models
{
    public class Carpark
    {
        private string carParkNumber { get; set; }
        private string description { get; set; }
        private string location { get; set; }

        public Carpark(string CarParkNumber, string Description, string Location) 
        {
            CarParkNumber = carParkNumber;
            Description = description;
            Location = location;
        }

    }
}
