namespace ChineseMorra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new();
            int winPoint = 5; 
            int userPoint = 0;
            int computerPoint = 0;
            bool EndGame = false;
            string winner;

            do
            {
                Console.WriteLine("User: " + userPoint + "\nComputer: " + computerPoint);

                try
                {
                    string[] word = ["Rock", "Scissors","Paper"];
                    Console.WriteLine("Choose your preference:\n1 Rock.\n2 Scissors\n3 Paper.");
                    int userChoice = Convert.ToInt32(Console.ReadLine());
                    int computerChoice = rand.Next(1, 4);

                    Console.WriteLine("User: " + word[userChoice - 1] + "\nComputer: " + word[computerChoice - 1]);

                    if (userChoice > 3)
                    { 
                        EndGame = true; 
                    } else
                    {

                        if (userChoice == computerChoice) {
                            Console.WriteLine("Draw");
                        } 
                        else
                        {
                            if ((userChoice == 1 && computerChoice != 2) || (userChoice == 2 && computerChoice != 3) || (userChoice == 3 && computerChoice != 1))
                            {
                                Console.WriteLine("Computer Win!");
                                ++computerPoint;

                            }
                            else
                            {
                                Console.WriteLine("User Win!");
                                ++userPoint;
                            }
                        }
                    }
                    if(userPoint == winPoint || computerPoint == winPoint) EndGame = true;
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();

                }
                catch (Exception e) 
                {
                    Console.WriteLine("Please insert a number!\n" + e.Message);
                }
            } while (!EndGame);


            winner = userPoint > computerPoint ? "User." : "Computer.";

            Console.WriteLine("The winner is: " + winner);
            Console.WriteLine("User: " + userPoint + "\nComputer: " + computerPoint);
        }

    }
}
