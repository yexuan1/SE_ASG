using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_ASG.Models
{
    public interface StatusState
    {
        public renewPass() { }
        public terminatePass(Vehicle vehicle) { }
        public transferPass() { }
        public makePayment() { }

    }
     
    public class Active : StatusState
    {
        private bool parked { get; set; }
        private SeasonParking myParking;
        
        public Active(SeasonParking parking)
        {
            myParking = parking;
        }

        public void terminatePass()
        {
            
        }

        public void transferPass(Vehicle vehicle) 
        {
        
        }

        public void makePayment() 
        {
        
        }

        public void renewPass()
        {

        }
        
    }
    public class Expired : StatusState 
    {
        public void terminatePass()
        {

        }

        public void transferPass(Vehicle vehicle)
        {

        }

        public void makePayment()
        {

        }

        public void renewPass()
        {

        }
    }
    public class Terminated : StatusState
    {
        public void generateRefund() 
        {
        
        }

        public void terminatePass()
        {

        }

        public void transferPass(Vehicle vehicle)
        {

        }

        public void makePayment()
        {

        }

        public void renewPass()
        {

        }
    }
}
