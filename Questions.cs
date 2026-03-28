using System;
using System.IO;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using static System.Console;


namespace chatboxPOE
{
   
        public class Questions
        {
        public Questions(string username)// (string username) is parameter and we pass the user's name into this class
        {
            // these are the Keywords that chatbot will look for
            string[] mainwords = { "how", "purpose", "ask", "cyber", "phishing", "password", "safe", "help" };
            // Responses that match each keyword
            string[] answer =
            {
                "I am doing well, thank you for asking!",
                "My purpose is to help you learn about cybersecurity and stay safe online.",
                "You can ask me about phishing, password safety, safe browsing, and general cybersecurity topics.",
                "Cybersecurity protects computers and networks from hackers.",
                "Phishing is a fake message designed to steal personal information.",
                "Use strong passwords and never share them.",
                "Safe browsing means avoiding suspicious websites.",
                "I can help answer cybersecurity awareness questions."
            };

            
                WriteLine("Hello " + username + "!");
            WriteLine("I am here to help you learn more about cyber security.");
            WriteLine("===================================================");

            // Infinite loop for continuous chat
            while (true)
            {
                
                Console.ForegroundColor = ConsoleColor.Green; // to make the username green 
                Write(username + ": ");
                Console.ResetColor();

                string question = ReadLine().ToLower();
                if (question == "exit")
                {
                    WriteLine(@"
   ██████   ██████   ██████  ██████  ██████  ██    ██ ███████
  ██       ██    ██ ██    ██ ██   ██ ██   ██  ██  ██  ██     
  ██   ███ ██    ██ ██    ██ ██   ██ ██████    ████   █████  
  ██    ██ ██    ██ ██    ██ ██   ██ ██   ██    ██    ██     
   ██████   ██████   ██████  ██████  ██████     ██    ███████

        Goodbye ,Stay Safe Online!");
                    break;
                }
                string[] split = question.Split(' ');

                bool found = false;

                foreach (string word in split)
                {
                    for (int i = 0; i < mainwords.Length; i++)
                    {
                        if (word == mainwords[i])
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Write("Chatbox: ");

                            Console.ResetColor();
                            foreach (char ch in answer[i])
                            {
                               
                                Write($"{ch}");
                                Thread.Sleep(50);
                            }
                            WriteLine();
                            Console.ResetColor();
                            found = true;
                            break;
                            
                        }
                    }

                    if (found)
                        break;
                }

                if (!found)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    WriteLine("Chatbox: I didn't quite get that, could you please rephrase?");
                    Console.ResetColor();
                }
            }
        }
           
            
        }
    }
    

