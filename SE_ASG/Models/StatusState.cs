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

        public void TerminatePass(string reason);

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

        public void TerminatePass(string reason)
        {
            Console.WriteLine("You have selected Terminate Pass.");
            myParking.setState(myParking.terminated);

        }

        public void TransferPass(Vehicle vehicle)
        {
            //Implementation
            myParking.setState(myParking.active);
        }

        public void MakePayment()
        {
            //Implementation
        }

        public void RenewPass()
        {
            //Implementation
            myParking.setState(myParking.active);
        }

    }
    public class Expired : StatusState
    {
        private SeasonParking myParking;

        public Expired(SeasonParking parking)
        {
            myParking = parking;
        }

        public void TerminatePass(string reason)
        {
            Console.WriteLine("You have selected Terminate Pass.");
            myParking.setState(myParking.terminated);
        }

        public void TransferPass(Vehicle vehicle)
        {
            //Implementation
            myParking.setState(myParking.active);
        }

        public void MakePayment()
        {
            //Implementation
        }

        public void RenewPass()
        {
            //Implementation
            myParking.setState(myParking.active);
        }
    }

    public class Terminated : StatusState
    {
        private SeasonParking myParking;

        public Terminated(SeasonParking parking)
        {
            myParking = parking;
        }

        public void GenerateRefund(float amount)
        {
            //Implementation
        }

        public void TerminatePass(string reason)
        {
            //Implementation
            Console.WriteLine("You have selected Terminate Pass.");
            myParking.setState(myParking.terminated);
        }

        public void TransferPass(Vehicle vehicle)
        {
            //Implementation
            myParking.setState(myParking.active);
        }

        public void MakePayment()
        {
            //Implementation
        }

        public void RenewPass()
        {
            //Implementation
            myParking.setState(myParking.active);
        }
    }
}
