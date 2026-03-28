using System;
using System.IO;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using static System.Console;
using System.Collections.Generic;
using System.Speech.Synthesis;


namespace chatboxPOE
{
    public class Voice
    {
        // Variable to store the user's name
        private string username = string.Empty;
        public Voice()
        {
            Validation valiobj = new Validation();
            string path_directory = AppDomain.CurrentDomain.BaseDirectory;

            string myvoice = path_directory.Replace("bin\\Debug", "");
            string voice = Path.Combine(myvoice, "New_Recording.wav"); // your voice file

            // PLAY VOICE FIRST
            play_voice(voice);

            // Ask user for their name AFTER voice plays
            WriteLine("Please enter your  name:");
            username = valiobj.GetValidName();

            // Display welcome message with user's name
            WriteLine("Welcome to Cyber security awareness chatbox " + username);
            WriteLine("======WELCOME========================================");


            // Display ASCII art
            WriteLine(@"


================  CYBER SECURITY AWARENESS BOT  =====================

            
 ██████╗██╗   ██╗██████╗ ███████╗██████╗     ██████╗  ██████╗ ████████╗
██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗    ██╔══██╗██╔═══██╗╚══██╔══╝
██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝    ██████╔╝██║   ██║   ██║   
██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗    ██╔══██╗██║   ██║   ██║   
╚██████╗   ██║   ██████╔╝███████╗██║  ██║    ██████╔╝╚██████╔╝   ██║   
 ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝    ╚═════╝  ╚═════╝    ╚═╝   

   Welcome! 
   I'm here to help you stay safe online.

   Protect your passwords
   Beware of phishing emails
   Avoid suspicious links
   Keep your data secure

   Let's keep you cyber-safe!
");

            WriteLine("==============================================");
        }
        // Method to play voice file
        public void play_voice(string voice)
        {
            try
            {
                using (SoundPlayer speechobj = new SoundPlayer(voice))
                {
                    speechobj.PlaySync(); // waits until voice finishes
                }
            }
            catch (Exception error)
            {
                WriteLine(error.Message);
            }
        }
        // Method to return the username to other classes
        public string return_name()
        {
            return username;
        }
    }
}

