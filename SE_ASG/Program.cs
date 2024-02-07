using System;

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

void processSeasonPass()
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

void terminateSeasonPass()
{
    bool return_to_menu = true;
    while (return_to_menu)
    {
        Console.WriteLine("=============Terminate Season Parking Pass============");
        Console.WriteLine();
        Console.WriteLine("---------------Valid Season Parking Passes------------");
        Console.WriteLine("   Pass Number: 5                          Monthly    ");
        Console.WriteLine("   Pass Number: 78                         Daily    ");
        Console.WriteLine("   Pass Number: 90                         Monthly    ");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Please Select the Pass Number to terminate (to abort enter 0) : ");
        string passNo = Console.ReadLine();
        if (passNo == "5" || passNo == "90")
        {
            Console.WriteLine("System has checked that the parking pass selected is a Monthly Pass");
            Console.WriteLine();
            Console.WriteLine("Please enter the reason for pass termination: ");
            string reason = Console.ReadLine();
            Console.WriteLine("To Confirm Pass Termination Enter 1 OR 0 to abort");
            string confirm = Console.ReadLine();
            Console.WriteLine();
            if (confirm == "1")
            {
                Console.WriteLine($"Terminating Pass No. {passNo}");
                Console.WriteLine();
                Console.WriteLine("System has calculated and refunded the unused months into the user's account");
                Console.WriteLine("System has updated the pass status to terminated and the number of available monthly season passes has been increased by 1");
                Console.WriteLine();
                Console.WriteLine("Thank You for using the Monthly Season Parking Pass!");
                Console.WriteLine();
                return_to_menu=false;
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
            Console.WriteLine("System has checked that the parking pass selected is a Daily Pass");
            Console.WriteLine();
            Console.WriteLine("Please enter the reason for pass termination: ");
            string reason = Console.ReadLine();
            Console.WriteLine("To Confirm Pass Termination Enter 1 OR 0 to abort");
            string confirm = Console.ReadLine();
            Console.WriteLine();
            if (confirm == "1")
            {
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