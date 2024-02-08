using SE_ASG.Models;
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace SE_ASG.Models
{
    class Program
    {
        // Note: The "STAThread" attribute is required for the FolderBrowserDialog class (which this program uses internally) to work as intended.
        [STAThread]
        static void Main()
        {
            bool isRunning = true;
            bool monthlyPassAvailable = false;
            bool paymentSuccess = false;
            bool inputIsValid = true;

            Console.WriteLine("Welcome to NP Parking Management System!");
            Console.WriteLine("How Can I Help You?");

            while (isRunning)
            {
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Process of Season Pass application");
                Console.WriteLine("2. Generate Financial Report");
                Console.WriteLine("3. Transfer Season Pass");
                Console.WriteLine("4. Terminate Season Pass");
                Console.WriteLine("5. Apply Season Pass");
                Console.WriteLine("6. Exit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        processSeasonPass();
                        break;
                    case "2":
                        GenerateFinancialReport();

                        break;
                    case "3":

                        break;
                    case "4":
                        terminateSeasonPass();
                        break;
                    case "5":

                        break;
                    case "6":
                        Console.WriteLine("Exiting....");
                        isRunning = false;

                        break;
                }
            }
        }

        static void processSeasonPass()
        {
            bool return_to_main_menu = true;
            Console.WriteLine("Welcome admin! This is the new application for you to view");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Application Details:");
            Console.WriteLine("Name: Jerel Sim");
            Console.WriteLine("StudentID: S10343578G");
            Console.WriteLine("Start month: A Date");
            Console.WriteLine("End month: A Date after Start month");
            Console.WriteLine("Vehicle type: Lorry");
            Console.WriteLine("License plate number: S1241KFUCA");
            Console.WriteLine("Unit Identifier: awleghasedoug ");
            Console.WriteLine("===========================================================");
            while (return_to_main_menu)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Approve Application");
                Console.WriteLine("2. Deny Application");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine("==========================================");
                    Console.WriteLine("Approving Application...");
                    Console.WriteLine("Status updated from Pending to Approved");
                    Console.WriteLine("System notify user of application approval");
                    Console.WriteLine("System issue user seasonal pass");
                    Console.WriteLine("==========================================");
                    Console.WriteLine("Returning to Main menu.....");
                    return_to_main_menu = false;
                }
                else if (choice == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("==========================================");
                    Console.WriteLine("Denying Application...");
                    Console.WriteLine("Status updated from Pending to Denied");
                    Console.WriteLine("System notify user of application Denial");
                    Console.WriteLine("==========================================");
                    Console.WriteLine("Returning to Main menu.....");
                    return_to_main_menu = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter either '1' or '2'.");
                }
            }
        }

        static void terminateSeasonPass()
        {
            bool return_to_menu = true;
            while (return_to_menu)
            {
                
                Console.WriteLine("=============Terminate Season Parking Pass============");
                Console.WriteLine();
                Console.WriteLine("---------------Valid Season Parking Passes------------");
                Console.WriteLine("   Pass Number: 5          Monthly             Valid  ");
                Console.WriteLine("   Pass Number: 78          Daily             Expired ");
                Console.WriteLine("   Pass Number: 90         Monthly             Valid  ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please Select the Pass Number to terminate (to abort enter 0) : ");
                string passNo = Console.ReadLine();
                if (passNo == "5" || passNo == "90")
                {
                    ICalculateCharge calculateCharge = null;
                    SeasonParking seasonParking = new SeasonParking(calculateCharge);
                    Active active = new Active(seasonParking);
                    Expired expired = new Expired(seasonParking);
                    Terminated terminated = new Terminated(seasonParking);
                    Console.WriteLine("System has verified that the parking pass selected is a Monthly Pass");
                    Console.WriteLine();
                    Console.WriteLine("Please enter the reason for pass termination: ");
                    string reason = Console.ReadLine();
                    Console.WriteLine("To Confirm Pass Termination Enter 1 OR 0 to abort");
                    string confirm = Console.ReadLine();
                    Console.WriteLine();
                    if (confirm == "1")
                    {
                        active.TerminatePass(reason);
                        seasonParking.setState(terminated);
                        Console.WriteLine($"Terminating Pass No. {passNo}");
                        Console.WriteLine();
                        Console.WriteLine("System has calculated and refunded the unused months into the user's account");
                        Console.WriteLine("System has updated the pass status to terminated and the number of available monthly season passes has been increased by 1");
                        Console.WriteLine("System increased Number of available monthly season passes by 1") ;
                        Console.WriteLine();
                        Console.WriteLine("Thank You for using the Monthly Season Parking Pass!");
                        Console.WriteLine();
                        return_to_menu = false;
                    }
                    else if (confirm == "0")
                    {
                        Console.WriteLine("Aborting....");
                        Console.WriteLine();
                        return_to_menu = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine();
                    }

                }
                else if (passNo == "78")
                {
                    ICalculateCharge calculateCharge = null;
                    SeasonParking seasonParking = new SeasonParking(calculateCharge);
                    Active active = new Active(seasonParking);
                    Expired expired = new Expired(seasonParking);
                    Terminated terminated = new Terminated(seasonParking);
                    Console.WriteLine("System has verified that the parking pass selected is a Daily Pass");
                    Console.WriteLine();
                    Console.WriteLine("Please enter the reason for pass termination: ");
                    string reason = Console.ReadLine();
                    Console.WriteLine("To Confirm Pass Termination Enter 1 OR 0 to abort");
                    string confirm = Console.ReadLine();
                    Console.WriteLine();
                    if (confirm == "1")
                    {
                        expired.TerminatePass(reason);
                        seasonParking.setState(terminated);
                        Console.WriteLine($"Terminating Pass No. {passNo}");
                        Console.WriteLine();
                        Console.WriteLine("Thank You for using the Daily Season Parking Pass!");
                        Console.WriteLine();
                        return_to_menu = false;
                    }
                    else if (confirm == "0")
                    {
                        Console.WriteLine("Aborting....");
                        Console.WriteLine();
                        return_to_menu = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine();
                    }
                }
                else if (passNo == "0")
                {
                    Console.WriteLine("Aborting....");
                    Console.WriteLine();
                    return_to_menu = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine();
                }

            }
        }

        static void GenerateFinancialReport()
        {
            Console.WriteLine("Please select a folder to place the generated financial report in.");

            FolderBrowserDialog selectFolderDialog = new FolderBrowserDialog();

            DialogResult selectFolderDialogResult = selectFolderDialog.ShowDialog();

            if (selectFolderDialogResult != DialogResult.OK)
            {
                return;
            }

            string financialReportFilePath = Path.Combine(selectFolderDialog.SelectedPath, "Financial-Report.txt");

            FinancialReport financialReport = new FinancialReport();

            string financialReportContents = String.Format(
                "Financial report for the month of '{0} {1}':\n",
                DateTimeFormatInfo.GetInstance(null).GetMonthName(
                    financialReport.Month.Month
                ),
                financialReport.Month.Year
            );

            double totalRevenueFromStaffVehicleParkingCharges = 300;

            double totalRevenueFromStudentVehicleParkingCharges = 500;

            double totalRevenueFromAllVehicleParkingCharges = totalRevenueFromStaffVehicleParkingCharges + totalRevenueFromStudentVehicleParkingCharges;

            financialReportContents += String.Format(
                "Total revenue generated from parking charges for all vehicles: {0:C2}\n",
                totalRevenueFromAllVehicleParkingCharges
            );

            financialReportContents += String.Format(
                "Total revenue generated from parking charges for vehicles owned by staff: {0:C2}\n",
                totalRevenueFromStaffVehicleParkingCharges
            );

            financialReportContents += String.Format(
                "Total revenue generated from parking charges for vehicles owned by students: {0:C2}\n",
                totalRevenueFromStudentVehicleParkingCharges
            );

            File.WriteAllText(financialReportFilePath, financialReportContents);

            Console.WriteLine("Successfully generated financial report.");
        }
        static void renewSeasonPass()
        {
            bool return_to_menu = true;
            while (return_to_menu)
            {
                int[] passes = { 1, 2, 3 };
                Console.WriteLine("=============Renew Season Parking Pass============");
                Console.WriteLine();
                Console.WriteLine("---------------Valid Season Parking Passes------------");
                Console.WriteLine("   Pass Number                                Type       ");
                Console.WriteLine($"   Pass Number: {passes[0]}                         Daily      ");
                Console.WriteLine($"   Pass Number: {passes[1]}                         Monthly    ");
                Console.WriteLine($"   Pass Number: {passes[2]}                         Monthly    ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please select the Pass Number to be renewed. (Select 0 to go back to main menu)");
                Console.Write("Option:");

                string pn = Console.ReadLine();
                //Return back to main menu
                if (pn == "0")
                {
                    return_to_menu = false;
                }
                //Pass 1
                else if (pn == "1")
                {
                    Console.WriteLine($"Confirm to renew this pass {pn}? (Y/N)");
                    string confirm = Console.ReadLine();
                    if (confirm == "Y" || confirm == "y")
                    {
                        Console.WriteLine("=============Renew Season Parking Pass============");
                        Console.WriteLine();
                        PaymentMethod savedCardPayment = new PaymentMethod("Saved card");

                        Console.WriteLine();
                        string payment = Console.ReadLine();
                        if (payment == "1")
                        {
                            Console.WriteLine("System verifying payment transaction...");
                            Console.WriteLine("");
                            Console.WriteLine("Payment successful!");
                            Console.WriteLine();
                            //formatting date to 1 month after date of renewal
                            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Today);
                            DateOnly endDate = currentDate.AddMonths(1);
                            Active active = new Active(); // Create an instance of Active
                                                          //string formattedDate = endDate.ToString("dd/MM/yyyy"); // Format newEndDate to "dd/MM/yyyy"
                                                          //Console.WriteLine($"Renewal date: {formattedDate}");
                            active.RenewPass(endDate);
                            Console.WriteLine("");
                            return_to_menu = false;
                        }
                        else if (payment == "2")
                        {
                            Console.WriteLine("Enter card details:");
                            string card = Console.ReadLine();
                            if (card == "1234")
                            {
                                Console.WriteLine("System verifying payment transaction...");
                                Console.WriteLine("");
                                Console.WriteLine("Payment successful!");
                                Console.WriteLine("");
                                //formatting date to 1 month after date of renewal
                                DateOnly currentDate = DateOnly.FromDateTime(DateTime.Today);
                                DateOnly endDate = currentDate.AddMonths(1);
                                Active active = new Active(); // Create an instance of Active
                                //string formattedDate = endDate.ToString("dd/MM/yyyy"); // Format newEndDate to "dd/MM/yyyy"
                                //Console.WriteLine($"Renewal date: {formattedDate}");
                                active.RenewPass(endDate);
                                Console.WriteLine("");
                                return_to_menu = false;
                            }
                            //Validation
                            else
                            {
                                Console.WriteLine("You have entered invalid card number");
                                Console.WriteLine();
                                renewSeasonPass();
                            }
                        }
                        //validation
                        else
                        {
                            Console.WriteLine("You have entered an invalid number");
                            Console.WriteLine();
                            renewSeasonPass();
                        }
                    }
                    else if (confirm == "N" || confirm == "n")
                    {
                        renewSeasonPass();
                    }
                }
                //Pass 2
                else if (pn == "2")
                {
                    Console.WriteLine("The pass has expired. Please select a valid season parking pass.");
                    Console.WriteLine();
                    renewSeasonPass();
                }
                //Pass 3
                else if (pn == "3")
                {
                    Console.WriteLine($"Confirm to renew this pass {pn}? (Y/N)");
                    string confirm = Console.ReadLine();
                    if (confirm == "Y" || confirm == "y")
                    {
                        Console.WriteLine("=============Renew Season Parking Pass============");
                        Console.WriteLine();
                        PaymentMethod savedCardPayment = new PaymentMethod("Saved card");

                        Console.WriteLine();
                        string payment = Console.ReadLine();
                        if (payment == "1")
                        {
                            Console.WriteLine("System verifying payment transaction...");
                            Console.WriteLine("");
                            Console.WriteLine("Payment successful!");
                            Console.WriteLine();
                            //formatting date to 1 month after date of renewal
                            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Today);
                            DateOnly endDate = currentDate.AddMonths(1);
                            Active active = new Active(); // Create an instance of Active
                                                          //string formattedDate = endDate.ToString("dd/MM/yyyy"); // Format newEndDate to "dd/MM/yyyy"
                                                          //Console.WriteLine($"Renewal date: {formattedDate}");
                            active.RenewPass(endDate);
                            Console.WriteLine("");
                            return_to_menu = false;
                        }
                        else if (payment == "2")
                        {
                            Console.WriteLine("Enter card details:");
                            string card = Console.ReadLine();
                            if (card == "1234")
                            {
                                Console.WriteLine("System verifying payment transaction...");
                                Console.WriteLine("");
                                Console.WriteLine("Payment successful!");
                                Console.WriteLine();
                                //formatting date to 1 month after date of renewal
                                DateOnly currentDate = DateOnly.FromDateTime(DateTime.Today);
                                DateOnly endDate = currentDate.AddMonths(1);
                                Active active = new Active(); // Create an instance of Active
                                //string formattedDate = endDate.ToString("dd/MM/yyyy"); // Format newEndDate to "dd/MM/yyyy"
                                //Console.WriteLine($"Renewal date: {formattedDate}");
                                active.RenewPass(endDate);
                                Console.WriteLine("");
                                return_to_menu = false;
                            }
                            //Validation
                            else
                            {
                                Console.WriteLine("You have entered invalid card number");
                                Console.WriteLine();
                                renewSeasonPass();
                            }
                        }
                        //validation
                        else
                        {
                            Console.WriteLine("You have entered an invalid number");
                            Console.WriteLine();
                            renewSeasonPass();
                        }
                    }
                    else if (confirm == "N" || confirm == "n")
                    {
                        renewSeasonPass();
                    }
                }
                //validation
                else
                {
                    Console.WriteLine("You have entered an invalid number");
                    Console.WriteLine();
                    renewSeasonPass();
                }
            }
        }
    }
}
