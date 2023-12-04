namespace Homework2
{
    public class Game
    {
        private Random random;
        private int compScore;
        private int playerScore;

        public Game()
        {
            random = new Random();
            compScore = 0;
            playerScore = 0;
        }

        public void Start()
        {
            do
            {
                int compNumber = random.Next(0, 10);
                Console.WriteLine("Guess the number");

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{i + 1} -> ");
                    int playerNumber = 0;

                    while (!int.TryParse(Console.ReadLine(), out playerNumber))
                    {
                        Console.WriteLine("Incorrect input!");
                        Console.Write($"{i + 1} -> ");
                    }

                    if (compNumber == playerNumber)
                    {
                        Console.WriteLine("Correct!\a");
                        playerScore++;
                        break;
                    }

                    if (i == 4 && compNumber != playerNumber)
                    {
                        Console.WriteLine($"You lose, the number was {compNumber}");
                        compScore++;
                        break;
                    }

                    Console.WriteLine("Try again\n");
                }

                Console.WriteLine($"Player score {playerScore}; Comp Score {compScore}");
                Console.WriteLine();

            } while (compScore != 5 && playerScore != 5);

            string message = compScore > playerScore ? "Computer wins" : "Player wins";

            Console.WriteLine(message);
        }
    }
}
