using System.Reflection.Metadata;
using static PaperRockScissors.CompChoice;

namespace PaperRockScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;
            string player;
            int computer;
            Random rand = new Random();

            while (!finished)
            {
                computer = rand.Next(0, 3);
                Choice compChoice = (Choice)computer;

                Console.WriteLine("enter \"paper\", \"rock\" or \"scissors\": ");
                player = Console.ReadLine();

                if (player == compChoice.ToString())
                {
                    Console.WriteLine(player + " VS " + compChoice + " -> DRAW !");
                }

                else
                {
                    switch (player)
                    {
                        case "paper":
                            if (compChoice.ToString() == "scissors")
                            {
                                Console.WriteLine(player + " VS " + compChoice + " -> YOU LOOSE!");
                            }
                            else
                            {
                                Console.WriteLine(player + " VS " + compChoice + " -> YOU WIN!");
                            }
                            break;

                        case "rock":
                            if (compChoice.ToString() == "paper")
                            {
                                Console.WriteLine(player + " VS " + compChoice + " -> YOU LOOSE!");
                            }
                            else
                            {
                                Console.WriteLine(player + " VS " + compChoice + " -> YOU WIN!");
                            }
                            break;

                        case "scissors":
                            if (compChoice.ToString() == "rock")
                            {
                                Console.WriteLine(player + " VS " + compChoice + " -> YOU LOOSE!");
                            }
                            else
                            {
                                Console.WriteLine(player + " VS " + compChoice + " -> YOU WIN!");
                            }
                            break;

                        default:
                            Console.WriteLine("TRY AGAIN");
                            break;
                    }

                }




            }



        }
    }




}
