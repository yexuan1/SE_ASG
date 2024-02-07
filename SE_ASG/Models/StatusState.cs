using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_ASG.Models
{
    public interface StatusState
    {
        public void RenewPass();

        public void TerminatePass();

        public void TransferPass(Vehicle vehicle);

        public void MakePayment();
    }

    public class Active : StatusState
    {
        private bool parked { get; set; }
        
        private SeasonParking myParking;
        
        public Active(SeasonParking parking)
        {
            myParking = parking;
        }

        public void TerminatePass()
        {
            
        }

        public void TransferPass(Vehicle vehicle) 
        {
        
        }

        public void MakePayment() 
        {
        
        }

        public void RenewPass()
        {

        }
        
    }
    public class Expired : StatusState 
    {
        public void TerminatePass()
        {

        }

        public void TransferPass(Vehicle vehicle)
        {

        }

        public void MakePayment()
        {

        }

        public void RenewPass()
        {

        }
    }

    public class Terminated : StatusState
    {
        public void GenerateRefund() 
        {
        
        }

        public void TerminatePass()
        {

        }

        public void TransferPass(Vehicle vehicle)
        {

        }

        public void MakePayment()
        {

        }

        public void RenewPass()
        {

        }
    }
}
