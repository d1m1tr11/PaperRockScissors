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
                computer = rand.Next(0,3);
                var compChoice = (CompChoice.Choice)computer;
                computerChoice = compChoice.ToString();



                Console.WriteLine("enter \"paper\", \"rock\" or \"scissors\": ");
                player = Console.ReadLine();
                switch (player)
                {
                    case "paper":
                        Console.WriteLine("paper " + computerChoice);
                        break;

                    case "rock":
                        Console.WriteLine("rock " + computerChoice);
                        break;

                    case "scissors":
                        Console.WriteLine("scissors " + computerChoice);
                        break;

                    default:
                        Console.WriteLine("TRY AGAIN");
                        break;
                }





            }



        }
    }




}
