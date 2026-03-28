using System;
using System.IO;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatboxPOE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voice voice = new Voice();   // object for the voice class
            Questions q = new Questions(voice.return_name()); // voice.return_name() returns the user's name (e.g "keletso")
            Validation valiobj  = new Validation(); // object for validation class

        }
    }
}
