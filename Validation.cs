using System.Linq;
using System;
using static System.Console;

namespace chatboxPOE
{
    public class Validation
    {
        
            public string GetValidName()
            {
                while (true)
                {
                    string name = ReadLine();

                    if (string.IsNullOrWhiteSpace(name))// if statement  to make sure that the user enters a name 
                    {
                    Console.ForegroundColor = ConsoleColor.Red;
                    WriteLine("Name cannot be empty. Please enter your  name:");
                    Console.ResetColor();
                    WriteLine("Please re-enter your name");
                    
                    continue;
                    }

                    // Check if name contains numbers
                    if (name.Any(char.IsDigit))
                    {
                    Console.ForegroundColor = ConsoleColor.Red;
                    WriteLine("Name cannot contain numbers. Please enter your name:");
                    Console.ResetColor();
                    continue;
                    }

                    // Check if name has at least 2 words
                    string[] words = name.Trim().Split(' ');
                    return name;
                }
            }
        // Method to validate chatbot input
        public string GetValidInput()
            {
                string input = ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                Console.ForegroundColor = ConsoleColor.Red;
                WriteLine("Chatbox: You entered nothing. Please type a question.");
                Console.ResetColor();
                return null;
                }

                return input.Trim().ToLower();
            }

            public void DefaultResponse()
            {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Chatbox: I didn't quite understand that. Could you rephrase?");
            Console.ResetColor();
        }
        }

    }
