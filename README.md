# Blue-Prism-Technical-Test
 This repository is my solution developed to solve the Blue Prism technical test using C#

This readme serves as a logbook for the work done in order to complete the technical test. 

## 18/8/2021
Upon first reading the project brief, the algorithm to generate the the list of words seemed a little daunting. For this reason, I broke the task down into features the application requires in order to function. 
The tasks list I created was:
- Create the basic structure of the application.
- Read user input and attempt to open a text file with the name provided by the user.
- Accept two words from the user
- Check the words are four characters in length
- creating the shortest list possible of words contained in the dictionary (changing one letter at a time) to move from the start word, to the end word.

I decided to start with what I knew how to do (although admittedly I am a little rusty with some aspects of .Net development so did need to check some things such as reading user input, and checking if a file exists). 
I began by layout out the main structure of the application, with placeholder TODO: notes. I made TODO: notes for each function the application needed to perform, before creating methods for the functions.

I then went and began filling out sections of code that I was more familiar with, starting with creating a method that checks if the user has typed the words "quit" or "exit", and exiting the program. I decided whenever the program performs this check, it should convert any string typed by the user to upper case, and then perform the check. This was just to ensure if the user types "Exit" or "QUit" for example, the application would still exit.
....
I've now worked on getting the user to type the file name and the application will check if the dictionary exists in the Dictionaries folder in the main directory of the application. This gives an error and if the file doesn't exist, asks the user again. 

## 19/8/2021
Having thought about the process the function should perform to create the lists, I will most likely split this into seperate functions. I have written out the pseudocode for this function, but at the moment it isn't complete.

## 23/8/2021
Continued working on loading the dictionary and checking each word exists in the dictionary. Also added a check to ensure each word entered is four letters long, and if either word isn't the program will ask again.