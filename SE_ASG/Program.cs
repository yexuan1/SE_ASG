﻿using SE_ASG.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
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
                Console.WriteLine("6. Renew Season Pass");
                Console.WriteLine("7. Exit");
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

                    case "6":
                        RenewSeasonPass();
                        break;
                    case "7":
                        Console.WriteLine("Exiting....");
                        isRunning = false;

                        break;
                }
            }
        }

        static void processSeasonPass()
        {

            bool return_to_main_menu = true;
            while (return_to_main_menu)
            {

                // Create an instance of SeasonParkingApplication to access the list of applications
                SeasonParkingApplication seasonParkingApp = new SeasonParkingApplication();

                var applications = seasonParkingApp.Applications;

                Console.WriteLine("Welcome admin! This is the new application for you to view");
                Console.WriteLine("===========================================================");
                // Iterate through the list of applications and print details with index
                for (int i = 0; i < applications.Count; i++)
                {
                    Console.WriteLine($"Application {i + 1} Details:");
                    foreach (var detail in applications[i])
                    {
                        Console.WriteLine($"{detail.Key}: {detail.Value}");
                    }
                    Console.WriteLine("===========================================================");
                }

                Console.WriteLine("Please select an application to process (enter the number 1 to 5, or 0 to go back to Main Menu):");
                string choice = Console.ReadLine();

                if (int.TryParse(choice, out int index))
                {
                    if (index == 0) // Exit condition
                    {
                        return_to_main_menu = false;
                        continue; // Skip the rest of the loop and exit
                    }
                    else if (index >= 1 && index <= applications.Count)
                    {
                        // Store the selected application's details
                        Dictionary<string, string> selectedApplication = applications[index - 1];

                        Console.WriteLine();
                        Console.WriteLine("You selected Application " + index);
                        Console.WriteLine("1. Approve Application");
                        Console.WriteLine("2. Deny Application");
                        string actionChoice = Console.ReadLine();

                        if (actionChoice == "1")
                        {
                            Console.WriteLine();
                            Console.WriteLine("==========================================");
                            Console.WriteLine("Approving Application...");
                            Console.WriteLine("Status updated from Pending to Approved");
                            Console.WriteLine("System notify user of application approval");
                            Console.WriteLine("System issue user seasonal pass");
                            Console.WriteLine("==========================================");

                            // Print selected application's details after processing
                            PrintApplicationDetails(selectedApplication);
                        }
                        else if (actionChoice == "2")
                        {
                            Console.WriteLine();
                            Console.WriteLine("==========================================");
                            Console.WriteLine("Denying Application...");
                            Console.WriteLine("Status updated from Pending to Denied");
                            Console.WriteLine("System notify user of application Denial");
                            Console.WriteLine("==========================================");

                            // Print selected application's details after processing
                            PrintApplicationDetails(selectedApplication);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter either '1' or '2'.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input. Please enter a number from 1 to {applications.Count}.");
                    }

                    Console.WriteLine("Do you want to process another application? (yes/no):");
                    string continueChoice = Console.ReadLine();
                    if (continueChoice.ToLower() != "yes")
                    {
                        return_to_main_menu = false;
                    }
                }
            }
        }

        // Method to print application details
        static void PrintApplicationDetails(Dictionary<string, string> application)
        {
            Console.WriteLine("Selected Application Details:");
            foreach (var detail in application)
            {
                Console.WriteLine($"{detail.Key}: {detail.Value}");
            }
            Console.WriteLine("===========================================================");
        }
        static void terminateSeasonPass()
        {
            bool return_to_menu = true;
            Random random = new Random();
            int randomNum = random.Next(1, 3); //random to simulate if there is no season parking pass
            while (return_to_menu)
            {
                if (randomNum == 1) 
                { 
                    Console.WriteLine("=============Terminate Season Parking Pass============");
                    Console.WriteLine();
                    Console.WriteLine("---------------All Season Parking Passes--------------");
                    Console.WriteLine("     Pass Number          Pass Type            Status ");
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
                            expired.TerminatePass(reason); // pass is expired 
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

                else
                {
                    Console.WriteLine("Error: You have no Season Parking Passes. Thanks!");
                    Console.WriteLine("Returning to Main Menu....");
                    Console.WriteLine();
                    return_to_menu = false;
                }

            }
        }

        static void GenerateFinancialReport()
        {
            Console.WriteLine("Please select a folder to save the generated financial report in.");

            FolderBrowserDialog selectFolderDialog = new FolderBrowserDialog();

            DialogResult selectFolderDialogResult = selectFolderDialog.ShowDialog();

            if (selectFolderDialogResult != DialogResult.OK)
            {
                return;
            }

            try
            {
                // If the path supplied to this method is invalid, it will throw an exception.
                Path.GetFullPath(selectFolderDialog.SelectedPath);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("You have entered an invalid folder path.");

                Console.ResetColor();

                return;
            }

            Console.Write("Specify a name for the financial report: ");

            string financialReportName = Console.ReadLine();

            string financialReportFilePath = Path.Combine(selectFolderDialog.SelectedPath, financialReportName + ".txt");

            Console.Write("Specify a month (i.e. January, February, June etc) to view the financial information for: ");

            string selectedMonthFullName = Console.ReadLine();

            int selectedMonth = DateTime.ParseExact(selectedMonthFullName, "MMMM", CultureInfo.InvariantCulture).Month;

            Console.Write("Specify a year to view the financial information for: ");

            int selectedYear = Convert.ToInt32(
                Console.ReadLine()
            );

            DateTime selectedDate = new DateTime(selectedYear, selectedMonth, 1);

            if (selectedDate > DateTime.Now)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(
                    "You have entered an invalid month and/or year."
                );

                Console.ResetColor();

                return;
            }

            Dictionary<FinancialReportInformationOptions, string> reportInfoOptionToStringRepresentationMap = new Dictionary<FinancialReportInformationOptions, string>()
            {
                { FinancialReportInformationOptions.ByAllVehicles, "Revenue generated by vehicle parking charges in ICTP's campus by all vehicles" },
                { FinancialReportInformationOptions.ByVehiclesOwnedByStaff, "Revenue generated by vehicle parking charges in ICTP's campus by vehicles owned by staff" },
                { FinancialReportInformationOptions.ByVehiclesOwnedByStudents, "Revenue generated by vehicle parking charges in ICTP's campus by vehicles owned by students" }
            };

            for (int currentIndex = 0; currentIndex < reportInfoOptionToStringRepresentationMap.Keys.Count; currentIndex++)
            {
                KeyValuePair<FinancialReportInformationOptions, string> reportInfoOptionMapEntry = reportInfoOptionToStringRepresentationMap.ElementAt(currentIndex);

                Console.WriteLine(
                    "{0}.) {1}",
                    currentIndex + 1,
                    reportInfoOptionMapEntry.Value
                );
            }

            Console.Write("Select the information that you would like to be included in the financial report (if you are selecting more than 1 choice, ensure that there is a comma between each of the choices): ");

            string[] selectedInformationOptionsAsStrings = Console.ReadLine().Trim().Split(",");

            List<FinancialReportInformationOptions> selectedReportInfoOptions = new List<FinancialReportInformationOptions>();

            foreach (string selectedInformationOptionAsString in selectedInformationOptionsAsStrings)
            {
                int selectedInformationOptionIndex = Convert.ToInt32(
                    selectedInformationOptionAsString
                ) - 1;

                KeyValuePair<FinancialReportInformationOptions, string> selectedReportInfoOptionKeyValuePair = reportInfoOptionToStringRepresentationMap.ElementAt(
                    selectedInformationOptionIndex
                );

                FinancialReportInformationOptions selectedReportInfoOption = selectedReportInfoOptionKeyValuePair.Key;

                selectedReportInfoOptions.Add(selectedReportInfoOption);
            }

            FinancialReport financialReport = new FinancialReport();

            financialReport.Month = DateOnly.FromDateTime(
                selectedDate
            );

            string financialReportContents = String.Format(
                "Financial report for the month of {0} {1}:\n",
                DateTimeFormatInfo.GetInstance(null).GetMonthName(
                    financialReport.Month.Month
                ),
                financialReport.Month.Year
            );

            double totalRevenueFromStaffVehicleParkingCharges = 300;

            double totalRevenueFromStudentVehicleParkingCharges = 500;

            double totalRevenueFromAllVehicleParkingCharges = totalRevenueFromStaffVehicleParkingCharges + totalRevenueFromStudentVehicleParkingCharges;

            foreach (FinancialReportInformationOptions selectedReportInfoOption in selectedReportInfoOptions)
            {
                double amount = 0;

                switch (selectedReportInfoOption)
                {
                    case FinancialReportInformationOptions.ByAllVehicles:
                    {
                        amount = totalRevenueFromAllVehicleParkingCharges;

                        break;
                    }
                    case FinancialReportInformationOptions.ByVehiclesOwnedByStaff:
                    {
                        amount = totalRevenueFromStaffVehicleParkingCharges;

                        break;
                    }
                    case FinancialReportInformationOptions.ByVehiclesOwnedByStudents:
                    {
                        amount = totalRevenueFromStudentVehicleParkingCharges;

                        break;
                    }
                }

                financialReportContents += String.Format(
                    "{0}: {1:C2}\n",
                    reportInfoOptionToStringRepresentationMap[selectedReportInfoOption],
                    amount
                );
            }

            File.WriteAllText(financialReportFilePath, financialReportContents);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("The financial report has been successfully generated.");

            Console.ResetColor();
        }
        static void RenewSeasonPass()
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
                            Active active = new(); // Create an instance of Active
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
                                Active active = new(); // Create an instance of Active
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
                                RenewSeasonPass();
                            }
                        }
                        //validation
                        else
                        {
                            Console.WriteLine("You have entered an invalid number");
                            Console.WriteLine();
                            RenewSeasonPass();
                        }
                    }
                    else if (confirm == "N" || confirm == "n")
                    {
                        RenewSeasonPass();
                    }
                }
                //Pass 2
                else if (pn == "2")
                {
                    Console.WriteLine("The pass has expired. Please select a valid season parking pass.");
                    Console.WriteLine();
                    RenewSeasonPass();
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
                            Active active = new(); // Create an instance of Active
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
                                Active active = new(); // Create an instance of Active
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
                                RenewSeasonPass();
                            }
                        }
                        //validation
                        else
                        {
                            Console.WriteLine("You have entered an invalid number");
                            Console.WriteLine();
                            RenewSeasonPass();
                        }
                    }
                    else if (confirm == "N" || confirm == "n")
                    {
                        RenewSeasonPass();
                    }
                }
                //validation
                else
                {
                    Console.WriteLine("You have entered an invalid number");
                    Console.WriteLine();
                    RenewSeasonPass();
                }
            }
        }
    }

    enum FinancialReportInformationOptions
    {
        ByAllVehicles,
        ByVehiclesOwnedByStaff,
        ByVehiclesOwnedByStudents
    }
}
