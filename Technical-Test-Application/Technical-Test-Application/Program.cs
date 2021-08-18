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

            // Attempt to load the dictionary
            DictionaryLoad();

            // Loop to allow the program to continually function until the user wants to exit.
            while(true)
            {
                // Get the two words from the user.
                (string firstWord, string secondWord) = WordsInput();

                Console.WriteLine("Your first word is: {0}", firstWord);
                Console.WriteLine("Your second word is: {0}", secondWord);

                // Check the words exist in the dictionary
                // TODO: CHECK EACH WORD EXISTS IN THE DICTIONARY
                CheckDictionary(firstWord);
                CheckDictionary(secondWord);

                // TODO: GENERATE LIST

                // TODO: WRITE FILE TO OUTPUT
            }
        }

        // Loads the dictionary into memory
        static void DictionaryLoad()
        {
            bool dictionaryLoaded = false;
            bool dictionaryPathValid = false;

            // Ask user for directory
            while (dictionaryLoaded == false)
            {


                Console.WriteLine("Please type the full directory path of the dictionary");
                string dictionaryPath = Console.ReadLine();
                // TODO: DICTIONARY VARIABLE

                if(dictionaryPathValid == true)
                {

                    dictionaryLoaded = true;
                    Console.WriteLine("Dictionary loaded!");
                }
                else
                {
                    Console.WriteLine("There was a problem loading the dictionary...");
                }



            }
        }

        // Retrieves the two words to check from the user
        static (string, string) WordsInput()
        {
            // Program main loop
            // Asks for user input. If the user types quit or exit, application exits
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



            return (firstWord, secondWord);


        }

        // Checks that the word exists in the dictionary
        static void CheckDictionary(string word)
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
