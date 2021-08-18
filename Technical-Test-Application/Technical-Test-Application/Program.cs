using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


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

                // TODO: CHECK EACH WORD EXISTS IN THE DICTIONARY

                // Check the words exist in the dictionary
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

            // Ask user for the file name of the dictionary they want to use.
            while (dictionaryLoaded == false)
            {
                Console.WriteLine("Please type the name of the file you wish to use or type quit or exit to quit the application.");
                Console.WriteLine("Note: The name of the included dictionary is called words-english.txt");
                string currentPath = System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString();
                string dictionariesPath = Path.GetFullPath(Path.Combine(currentPath, @"..\..\Dictionaries"));
                //Console.WriteLine(dictionariesPath);
                string fileName = Console.ReadLine();
                // Save user input as upper case. Used to check if the user wants to exit the application...
                // ...by typing "exit" or "quit".
                string exitCheck = fileName.ToUpper();
                ExitCheck(exitCheck);

                string filePath = Path.Combine(dictionariesPath, fileName);
                //Console.WriteLine(filePath);
                
                if (File.Exists(filePath))
                {
                    // TODO: TRY/CATCH LOAD DICTIONARY
                    // TODO: IF DICTIONARY IS LOADED: CONTINUE. ELSE GIVE ERROR MESSAGE
                    dictionaryLoaded = true;
                    Console.WriteLine("Dictionary loaded!");
                }
                else
                {
                    Console.WriteLine("\nThe following file does not exist: {0}", fileName);
                    Console.WriteLine("Please ensure the file is in the following directory:\n{0}\n", dictionariesPath);
                }
            }
        }

        // Asks user to input two words and returns them.
        static (string, string) WordsInput()
        {
            // Asks for user for two words. These are used to search the dictionary
            Console.WriteLine("Please type the first word to check from the dictionary");

            // Read user input (first word)
            string userInput = Console.ReadLine();

            // Save user input as upper case. Used to check if the user wants to exit the application...
            // ...by typing "exit" or "quit".
            string exitCheck = userInput.ToUpper();
            ExitCheck(exitCheck);

            string firstWord = userInput;

            // Asks for user input (second word)
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
            // TODO: CHECK DICTIONARY FOR WORDS
        }

        static void GenerateList()
        {
            // TODO: Generate list using the two words given by the user
        }

        static void OutputFile(string word)
        {
            // TODO: SET FILE DIRECTORY
            // TODO: ASK USER FOR FILE NAME
            // TODO: WRITE FILE TO DIRECTORY
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
