using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            //Run GetAppInfo function to get app details
            GetAppInfo();

            // Run GreetUser to ask for user's name and greet
            GreetUser();

            while (true)
            {

                // Create a Random Object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 11);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Gets user input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // print error message as user entered an invalid number
                        PrintColorMessage(ConsoleColor.Red, "Please enter a actual number");

                        continue;
                    }

                    // Cast into int and put it in guess
                    guess = Int32.Parse(input);

                    // Match guess with correct number
                    if (guess != correctNumber)
                    {
                        // print error message as user entered wrong number
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");

                    }
                }

                // print succes message as user guessed correct
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!");

                // Ask user to play again or not
                Console.WriteLine("Do you want to play again [ Y/N ] ? ");

                // Get user answer
                string answer = Console.ReadLine().ToUpper();

                // Check whether user wants to play or not
                if (answer == "Y") {
                    continue;
                }
                else if (answer == "N") {
                    return;
                }
                else {
                    return;
                }

            }
        }

        // Get and display App info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Allen Carvallo";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Print app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();

            
        }

        // Get user's name and greet
        static void GreetUser()
        {
            // Ask Users name
            Console.WriteLine("What is your name ?");

            // Get User input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print colored message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
    
}
