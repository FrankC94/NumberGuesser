using System;

// Namespace
namespace ConsoleApp1
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function to get info

            GreetUser(); // Greet the user

            while (true)
            {
                // Init correct number
                // int correctNumber = 7;

                //Create a new Random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Init guess Var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    //Get user input
                    string input = Console.ReadLine();

                    // Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMesage(ConsoleColor.Red, "Please use an actual number");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMesage(ConsoleColor.Red, "Wrong number, please try again");
                    }

                }
                // Output success message

                PrintColorMesage(ConsoleColor.Blue, "Correct!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                } 
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        // This displays the App info 
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Frank Cedeno";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;
            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }
        // Ask users name and greets 
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("what is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game!", inputName);
        }
        // Print color message
        static void PrintColorMesage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;
            // tell user not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
