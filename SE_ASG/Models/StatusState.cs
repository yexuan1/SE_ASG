using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_ASG.Models
{
    public interface StatusState
    {
        public void RenewPass(DateOnly newEndDate);

        public void TerminatePass(string reason);

        public void TransferPass(Vehicle vehicle);

        public bool MakePayment(float amount);
    }

    public class Active : StatusState
    {
        private bool parked { get; set; }

        private SeasonParking myParking;

        public Active(SeasonParking parking)
        {
            myParking = parking;
        }
        public Active()
        {
        }

        public void TerminatePass(string reason)
        {
            myParking.setState(myParking.terminated);
            Console.WriteLine("Your pass has now been terminated.");
        }

        public void TransferPass(Vehicle vehicle)
        {
            //Implementation
            myParking.setState(myParking.active);
        }

        public bool MakePayment(float amount)
        {
            //Implementation
            return true;
        }

        public void RenewPass(DateOnly newEndDate)
        {
            //Implementation
            //myParking.setState(myParking.active);
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Today);
            DateOnly endDate = currentDate.AddMonths(1);
            string formattedEndDate = endDate.ToString("dd/MM/yyyy");
            Console.WriteLine($"Date of expiry has been updated to {formattedEndDate}.");

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
            myParking.setState(myParking.terminated);
            Console.WriteLine("Your pass has now been terminated.");
        }

        public void TransferPass(Vehicle vehicle)
        {
            //Implementation
            myParking.setState(myParking.active);
        }

        public bool MakePayment(float amount)
        {
            //Implementation
            return true;
        }

        public void RenewPass(DateOnly newEndDate)
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

        public float GenerateRefund()
        {
            //Implementation
            float refundAmt = 0;
            return refundAmt;
        }

        public void TerminatePass(string reason)
        {
            //Implementation
        }

        public void TransferPass(Vehicle vehicle)
        {
            //Implementation
            myParking.setState(myParking.active);
        }

        public bool MakePayment(float amount)
        {
            //Implementation
            return true;
        }

        public void RenewPass(DateOnly newEndDate)
        {
            //Implementation
            myParking.setState(myParking.active);
        }
    }
}
