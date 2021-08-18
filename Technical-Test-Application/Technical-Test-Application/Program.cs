using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical_Test_Application
{
    class Program
    {


        static void Main(string[] args)
        {


            Console.WriteLine("Hello! This application will attempt to find the shortest ---");
            Console.WriteLine("Exit the application at any time by typing quit or exit");

            Console.WriteLine("Loading Dictionary..");
            
            DictionaryLoad();

            WordsInput();

        }

        static void DictionaryLoad()
        {
            // TODO: LOAD DICTIONARY
            // ARGUMENT OR INSERT INTO APPLICATION??

            // TODO: IF DICTIONARY IS SUCCESSFULLY LOADED:
            if (1 == 1)
            {
                Console.WriteLine("Dictionary loaded!");

                // DICTIONARY VARIABLE
                // PASS DICTIONARY TO WORD CHECKS
            }
            else
            {
                // Dictionary not loaded. Exit
                Console.WriteLine("There was a problem loading the dictionary. Press any key to exit...");
                Console.ReadKey();
                Environment.Exit(1);
            }
        }

        static void WordsInput()
        {
            // Program main loop
            // Asks for user input. If the user types quit or exit, application exits
            while (true)
            {
                Console.WriteLine("Please type the first word to check from the dictionary");


                // Read user input
                string userInput = Console.ReadLine();
                
                // Save user input as upper case. Used to check if the user wants to exit the application...
                // ...by typing "exit" or "quit".
                string exitCheck = userInput.ToUpper();
                ExitCheck(exitCheck);

                string firstWord = userInput;

                Console.WriteLine("Please type the second word to check from the dictionary");
                userInput = Console.ReadLine();

                exitCheck = userInput.ToUpper();
                ExitCheck(exitCheck);

                string secondWord = userInput;
                CheckDictionary(firstWord, secondWord);

                Console.WriteLine("Your first word is: {0}", firstWord);
                Console.WriteLine("Your second word is: {0}", secondWord);

            }

        }

        static void CheckDictionary(string firstWord, string secondWord)
        {
            //TODO: CHECK DICTIONARY FOR WORDS
        }

        // Checks if the user has typed "exit" or "quit"
        static void ExitCheck(string exitCheck)
        {
            if (exitCheck == "EXIT" || exitCheck == "QUIT")
            {
                Environment.Exit(0);
            }

        }
    }
}
