using System.Reflection.Metadata;

namespace PaperRockScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;
            string player;
            int computer;
            string computerChoice;
            Random rand = new Random();

            while (!finished)
            {
                computer = rand.Next(0, 3);
                var compChoice = (CompChoice.Choice)computer;
                computerChoice = compChoice.ToString();



                Console.WriteLine("enter \"paper\", \"rock\" or \"scissors\": ");
                player = Console.ReadLine();

                if (player == computerChoice)
                { 
                    Console.WriteLine(player + " VS " + computerChoice + " -> DRAW !");
                }

                else 
                {
                    switch (player)
                    {
                        case "paper":
                            if (computerChoice == "scissors")
                            {
                                Console.WriteLine(player + " VS " + computerChoice + " -> YOU LOOSE!");
                            }
                            else
                            {
                                Console.WriteLine(player + " VS " + computerChoice + " -> YOU WIN!");
                            }
                            break;

                        case "rock":
                            if (computerChoice == "paper")
                            {
                                Console.WriteLine(player + " VS " + computerChoice + " -> YOU LOOSE!");
                            }
                            else
                            {
                                Console.WriteLine(player + " VS " + computerChoice + " -> YOU WIN!");
                            }
                            break;

                        case "scissors":
                            if (computerChoice == "rock")
                            {
                                Console.WriteLine(player + " VS " + computerChoice + " -> YOU LOOSE!");
                            }
                            else
                            {
                                Console.WriteLine(player + " VS " + computerChoice + " -> YOU WIN!");
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
