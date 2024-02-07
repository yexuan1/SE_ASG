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
