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
            string[] dictionary = new string[0];

            Console.WriteLine("Hello! This application will attempt to find the shortest path between two words.");
            Console.WriteLine("Exit the application at any time by typing quit or exit");

            // Attempt to load the dictionary
            dictionary = DictionaryLoad();

            // Loop to allow the program to continually function until the user wants to exit.
            while (true)
            {
                bool wordOneInDictionary = false;
                bool wordTwoInDictionary = false;

                // Get the two words from the user.
                (string firstWord, string secondWord) = WordsInput();

                Console.WriteLine("Your first word is: {0}", firstWord);
                Console.WriteLine("Your second word is: {0}", secondWord);

                // Check the words exist in the dictionary
                wordOneInDictionary = DictionaryWordCheck(firstWord, dictionary);
                wordTwoInDictionary = DictionaryWordCheck(secondWord, dictionary);

                if (wordOneInDictionary == true && wordTwoInDictionary == true)
                {
                    // TODO: GENERATE LIST
                    GenerateList();

                    // TODO: WRITE FILE TO OUTPUT
                    OutputFile();
                }
                else
                {
                    // Display words typed that were not found in dictionary.
                    Console.WriteLine("The following words were not found in the dictionary:");
                    if (wordOneInDictionary == false)
                    {
                        Console.WriteLine(firstWord);
                    }
                    if(wordTwoInDictionary == false)
                    {
                        Console.WriteLine(secondWord);
                    }
                }
            }
        }

        // Loads the dictionary into memory
        static string[] DictionaryLoad()
        {
            bool dictionaryLoaded = false;
            string[] dictionary = new string[0];

            // Ask user for the file name of the dictionary they want to use.
            while (dictionaryLoaded == false)
            {
                // File should be located in a Dictionaries folder in the main application folder.
                string fileName = "words-english.txt";
                string currentPath = System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString();
                string dictionariesPath = Path.GetFullPath(Path.Combine(currentPath, @"..\..\Dictionaries"));
                //Console.WriteLine(dictionariesPath);

                // Save user input as upper case. Used to check if the user wants to exit the application...
                // ...by typing "exit" or "quit".
                string exitCheck = fileName.ToUpper();
                ExitCheck(exitCheck);

                // Full path of the file
                string filePath = Path.Combine(dictionariesPath, fileName);

                // If file exists in path...
                if (File.Exists(filePath))
                {
                    // Try to load the file, or exit the application
                    try
                    {
                        dictionary = System.IO.File.ReadAllLines(filePath);
                        dictionaryLoaded = true;
                        Console.WriteLine("Dictionary loaded!");
                    }
                    catch
                    {
                        Console.WriteLine("There was an error loading the file. Press any key to exit");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
                // If the file does not exist in the correct path, exit the application.
                else
                {
                    Console.WriteLine("\nThe following file does not exist: {0}", fileName);
                    Console.WriteLine("The dictionary file should be located in:\n{0}\n", dictionariesPath);

                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            return dictionary;
        }

        // Asks user to input two words and returns them.
        static (string, string) WordsInput()
        {
            string userInput;
            string exitCheck;
            string firstWord = string.Empty;
            string secondWord = string.Empty;
            bool wordOneValid = false;
            bool wordTwoValid = false;

            // Continually ask for first word until user inputs a four letter word.
            while (wordOneValid == false)
            {
                // Asks for user for two words. These are used to search the dictionary
                Console.WriteLine("Please type the first word to check from the dictionary.");
                
                // Read user input (first word)
                userInput = Console.ReadLine();
                // Save user input as upper case. Used to check if the user wants to exit the application...
                // ...by typing "exit" or "quit".
                exitCheck = userInput.ToUpper();
                ExitCheck(exitCheck);
                // Check the word is four letters long.
                wordOneValid = ValidWordsCheck(userInput);
                firstWord = userInput;
            }

            // Continually ask for second word until user inputs a four letter word.
            while (wordTwoValid == false)
            {
                // Asks for user input (second word)
                Console.WriteLine("Please type the second word to check from the dictionary.");
                userInput = Console.ReadLine();
                // Perform exit check.
                exitCheck = userInput.ToUpper();
                ExitCheck(exitCheck);
                // Check second word is four letters long.
                wordTwoValid = ValidWordsCheck(userInput);
                secondWord = userInput;
            }
            return (firstWord, secondWord);
        }

        // Checks that the word exists in the dictionary
        static bool DictionaryWordCheck(string word, string[] dictionary)
        {
            bool wordPresent = false;
            foreach(string line in dictionary)
            {
                if (word.ToLower() == line.ToLower())
                {
                    wordPresent = true;
                }
            }
            return (wordPresent);
        }

        // Generates a 2D array of paths
        static void GenerateList()
        {
            // TODO: Generate list using the two words given by the user
        }

        // Outputs the result to a file.
        static void OutputFile()
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

        // Checks that an entered word is four characters long.
        static bool ValidWordsCheck(string word)
        {
            bool wordValid = false;

            if (word.Length == 4)
            {
                wordValid = true;
            }
            else
            {
                Console.WriteLine("This word is not four letters long.");
            }

            return (wordValid);
        }

        static string AskUserForFileName()
        {
            Console.WriteLine("Please type the name of the file you wish to use or type quit or exit to quit the application.");
            Console.WriteLine("Note: The name of the included dictionary is called words-english.txt");
            string fileName = Console.ReadLine();

            return (fileName);
        }
    }
}
