using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_ASG.Models
{
    public class SeasonParkingApplication
    {
        public Boolean passApplySucess { get; set; }


        public List<Dictionary<string, string>> Applications { get; private set; }

        // Constructor
        public SeasonParkingApplication()
        {
            Applications = new List<Dictionary<string, string>>();
            PopulateApplications();
        }

        // Method to populate the list of applications
        private void PopulateApplications()
        {
           
            Dictionary<string, string> application1 = new Dictionary<string, string>();
            application1.Add("Name", "Jerel Sim");
            application1.Add("StudentID", "S10343578G");
            application1.Add("Start month", "January");
            application1.Add("End month", "March");
            application1.Add("Vehicle type", "Lorry");
            application1.Add("License plate number", "S1241KFUCA");
            application1.Add("Unit Identifier", "awleghasedoug");
            Applications.Add(application1);


            Dictionary<string, string> application2 = new Dictionary<string, string>();
            application2.Add("Name", "Emily Chen");
            application2.Add("StudentID", "S10343579G");
            application2.Add("Start month", "February");
            application2.Add("End month", "April");
            application2.Add("Vehicle type", "Van");
            application2.Add("License plate number", "S6789JKLCA");
            application2.Add("Unit Identifier", "dserhegnkjdsf");
            Applications.Add(application2);

            Dictionary<string, string> application3 = new Dictionary<string, string>();
            application3.Add("Name", "Sophia Lee");
            application3.Add("StudentID", "S10343580G");
            application3.Add("Start month", "March");
            application3.Add("End month", "May");
            application3.Add("Vehicle type", "Car");
            application3.Add("License plate number", "S9876XYZCA");
            application3.Add("Unit Identifier", "gdfhsgdfh");
            Applications.Add(application3);

            Dictionary<string, string> application4 = new Dictionary<string, string>();
            application4.Add("Name", "Michael Wong");
            application4.Add("StudentID", "S10343581G");
            application4.Add("Start month", "April");
            application4.Add("End month", "June");
            application4.Add("Vehicle type", "Motorcycle");
            application4.Add("License plate number", "S5432ABCMA");
            application4.Add("Unit Identifier", "sdfjksdfh");
            Applications.Add(application4);

            Dictionary<string, string> application5 = new Dictionary<string, string>();
            application5.Add("Name", "Isabella Smith");
            application5.Add("StudentID", "S10343582G");
            application5.Add("Start month", "May");
            application5.Add("End month", "July");
            application5.Add("Vehicle type", "Truck");
            application5.Add("License plate number", "S1111QWERCA");
            application5.Add("Unit Identifier", "dfhsgfsh");
            Applications.Add(application5);
        }
    }
}
