using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace SE_ASG.Models
{
    public class User
    {
        private string Name { get; set; }
        private int userId { get; set; }
        private string username { get; set; }
        private string password { get; set; }
        private int mobileNumber { get; set; }

        public User(string name, int userid, string username, string password, int mobileNumber)
        {
            Name = name;
            userId = userid;
            username = username;
            password = password;
            mobileNumber = mobileNumber;
        }

    }
  

}
