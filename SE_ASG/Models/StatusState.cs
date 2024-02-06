using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_ASG.Models
{
    public class StatusState
    {
        public renewPass() { }
        public terminatePass() { }
        public transferPass() { }
        public makePayment() { }

    }

    public class Active : StatusState
    {
        private bool parked { get; set; }
        
    }
    public class Expired : StatusState { }
    public class Terminated : StatusState
    {
        public generateRefund() { }
    }
}
