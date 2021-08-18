# Blue-Prism-Technical-Test
 This repository is my solution developed to solve the Blue Prism technical test using C#

This readme serves as a logbook for the work done in order to complete the technical test. 

## 18/8/2021
Upon first reading the project brief, the algorithm to generate the the list of words seemed a little daunting.
To begin with, I broke the project down into things the application requires in order to function. 
The aspects I determined were: the project needs to read user input and attempt to open a text file with the name provided by the user.
The application also needs to accept two words from the user, before creating the shortest list possible of words contained in the dictionary (changing one letter at a time) to move from the starting word, to the end word.
I decided to start with what I knew how to do (although admittedly I am a little rusty with some aspects of .Net development so did need to check things such as reading user input). I began by layout out the main structure of the application, with placeholder TODO: notes. I filled in everything I could think that the application needs in order to perform its function.
I then went and began filling out sections of code that I was more familiar with, starting with creating a method that checks if the user has typed the words "quit" or "exit", and exiting the program. I decided whenever the program performs this check, it should convert any string typed by the user to upper case, and then perform the check. This was just to ensure if the user types "Exit" or "QUit" for example, the application would still exit.