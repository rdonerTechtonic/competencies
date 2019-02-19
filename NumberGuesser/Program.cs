using System;

namespace NumberGuesser
{
    class MainClass
    {
        //entry point method
        //static means we are referring to the function itself
        //void means it doesn't return anything
        public static void Main(string[] args)
        {
            GetAppInfo();

            //ask for users name and greet
            GreetUser();
            while (true)
            {
                //create a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //init guess var
                int guess = 0;

                //ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    //get users input
                    string input = Console.ReadLine();

                    //make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");

                        //Keep going
                        continue;
                    }

                    //cast to int and put in guess
                    guess = Int32.Parse(input);

                    //match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "You are correct!!!");

                Console.WriteLine("Play again? [Y or N]");

                //get answer 
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y") {
                    continue;
                } else if (answer == "N")
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            //setup app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Ryan Doner";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //reset text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //ask users name
            Console.WriteLine("What is your name?");

            //get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}! Let's play a game...", inputName);

        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //change text color
            Console.ForegroundColor = color;

            //tell user they guessed right
            Console.WriteLine(message);

            //reset text color
            Console.ResetColor();
        }
    }
}
