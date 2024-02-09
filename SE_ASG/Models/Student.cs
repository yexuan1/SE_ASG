using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_ASG.Models
{
    internal class Student : User
    {
        public Student(string name, int userid, string username, string password, int mobileNumber) : base(name, userid, username, password, mobileNumber)
        {
            //implementation
        }
    }
}
