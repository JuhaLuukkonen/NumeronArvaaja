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
            GetAppInfo(); // Ajaa GetAppInfo toiminnon saadakseen infon

            GreetUser(); // Kysyy käyttäjältä nimen ja tervehtii

            while (true)
            {

                // Init correct number
                //int correctNumber = 7;

                // Create a new Random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Arvaa numero väliltä 1 ja 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Antaisitko oikean numeron?");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Väärä numero, yritäthän uudestaan?");
                    }
                }

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "OIKEIN!! Arvasit sen!");

                // Ask to play again
                Console.WriteLine("Pelaatko uudestaan? [K or E]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "K")
                {
                    continue;
                }
                else if (answer == "E")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }

        // Get and display app info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Numeron Arvaaja";
            string appVersion = "1.0.0";
            string appAuthor = "Juha Luukkonen";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Ask users name and greet
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("Mikä on nimesi?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hei, {0}, pelataan peliä...", inputName);
        }

        // Print color message
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
