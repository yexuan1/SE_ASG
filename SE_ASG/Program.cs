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
    Console.WriteLine("Name:Jerel Sim");
    Console.WriteLine("StudentID:S10343578G");
    Console.WriteLine("Start month: A Date");
    Console.WriteLine("End month: A Date after Start month");
    Console.WriteLine("Vehicle type: Lorry");
    Console.WriteLine("License plate number: S1241KFUCA");
    Console.WriteLine("Unit Identifier: awleghasedoug ");
    Console.WriteLine("===========================================================");
    while (return_to_main_menu)
    {
        Console.WriteLine("Would you want to approve this application?");
        Console.WriteLine("1. Approve");
        Console.WriteLine("2. Deny");
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
            Console.WriteLine("Please enter a valid response, not empty text");
        }

    }
}