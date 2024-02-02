using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_ASG.Models
{
    public class User
    {
        private string name { get; set; }
        private int userId { get; set; }
        private string username { get; set; }
        private string password { get; set; }
        private int mobileNumber { get; set; }

    }
    public class Student : User{ }
    public class Staff : User{ }
    public class Admin : User{ }

}
