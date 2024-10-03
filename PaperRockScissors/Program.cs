using System.Reflection.Metadata;
using static PaperRockScissors.CompChoice;

namespace PaperRockScissors
{
    internal class Program
    {


        static void Main(string[] args)
        {
            bool finished = false;
            // int computer; aq jobs gamovacxado tu sadac viyeneb iqve ?
            // int user;
            Random rand = new Random();






            while (!finished)
            {
                Console.WriteLine("\n");
                Console.WriteLine("enter \"paper\" = 1, \"rock\" = 2 or \"scissors\": = 3 ");
                
                bool success = int.TryParse(Console.ReadLine(), out int user);
                if (success)
                {

                    if (user == 1 || user == 2 || user == 3)
                    {

                        int computer = rand.Next(1, 4);
                        Choice compChoice = (Choice)computer;
                        Choice userChoice = (Choice)user;

                        if (computer == user)
                        {
                            Console.WriteLine(userChoice + " VS " + compChoice + " It's DRAW! ");
                        }

                        else if (user == 1 && computer == 2)
                        {
                            Console.WriteLine(userChoice + " VS " + compChoice + " Player Wins! ");
                        }

                        else if (user == 2 && computer == 3)
                        {
                            Console.WriteLine(userChoice + " VS " + compChoice + " Player Wins! ");
                        }

                        else if (user == 3 && computer == 1)
                        {
                            Console.WriteLine(userChoice + " VS " + compChoice + " Player Wins! ");
                        }

                        else
                        {
                            Console.WriteLine(userChoice + " VS " + compChoice + " Player Loose! ");
                        }
                    }

                    else
                    {
                        Console.WriteLine("TRY AGAIN 1, 2 or 3: ");
                    }
                }
                else 
                {
                    Console.WriteLine("ARE YOU DUMB ?"); 
                }

            }




        }



    }
}





