namespace ChineseMorra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new();
            int winPoint = 4; 
            int userPoint = 0;
            int computerPoint = 0;
            bool game = false;
            string winner;

            do
            {
                Console.WriteLine("User: " + userPoint + "\nComputer: " + computerPoint);

                try
                {
                    string[] word = ["Rock", "Paper", "Scissors"];
                    Console.WriteLine("Choose your preference:\n1 Rock.\n2 Scissors\n3 Paper.");
                    int userChoice = Convert.ToInt32(Console.ReadLine());
                    int computerChoice = rand.Next(1, 4);

                    Console.WriteLine("User: " + word[userChoice - 1] + "\nComputer: " + word[computerChoice - 1]);

                    if (userPoint == winPoint || computerPoint == winPoint || userChoice > 3)
                    { 
                        game = true; 
                    } else
                    {

                        if (userChoice == computerChoice) {
                            Console.WriteLine("Draw");
                        } 
                        else
                        {
                            if ((userChoice == 1 && computerChoice != 2) || (userChoice == 2 && computerChoice != 3) || (userChoice == 3 && computerChoice != 1))
                            {
                                Console.WriteLine("User Win!");
                                userPoint++;
                            }
                            else
                            {
                                Console.WriteLine("Computer Win!");
                                computerPoint++;
                            }
                        }
                    }
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();

                }
                catch (Exception e) 
                {
                    Console.WriteLine("Please insert a number!\n" + e.Message);
                }
            } while (!game);


            winner = userPoint > computerPoint ? "User." : "Computer.";

            Console.WriteLine("The winner is: " + winner);
            Console.WriteLine("User: " + userPoint + "\nComputer: " + computerPoint);
        }

    }
}
