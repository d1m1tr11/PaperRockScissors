using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PaperRockScissors
{
    public class PlayAgain
    {

        public static bool Playing()
        {
           
        Console.WriteLine("wanna play again? ");
        string userChoice = Console.ReadLine();

            if (userChoice != null && userChoice == "y")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
