
namespace CSharpMathGame
{
    internal class GameEngine
    {

        internal void AdditionGame(string message)
        {
            Console.WriteLine(message);

            Random randNum = new Random();
            int num1;
            int num2;
            int gameTries = 5;
            int score = 0;

            for (int i = 0; i < gameTries; i++)
            {
                num1 = randNum.Next(1, 9);
                num2 = randNum.Next(1, 9);

                Console.WriteLine($"{num1} + {num2}");

                string? result = Console.ReadLine() ?? "0";

                if (int.Parse(result) == num1 + num2)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }
                if (i == gameTries - 1)
                {
                    Console.WriteLine($"\nGame Over. Your score is {score}/{gameTries}.");
                    Console.WriteLine("====================================\n");
                }
            }
            Helpers.AddToGameHistory("Addition", score);

            Console.WriteLine("Press enter to return to the menu.");
            Console.ReadLine();

        }

        internal void SubtractionGame(string message)
        {
            Console.WriteLine(message);

            Random randNum = new Random();
            int num1;
            int num2;
            int gameTries = 5;
            int score = 0;

            for (int i = 0; i < gameTries; i++)
            {
                num1 = randNum.Next(1, 9);
                num2 = randNum.Next(1, 9);

                Console.WriteLine($"{num1} - {num2}");

                string? result = Console.ReadLine() ?? "0";

                if (int.Parse(result) == num1 - num2)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }
                if (i == gameTries - 1)
                {
                    Console.WriteLine($"\nGame Over. Your score is {score}/{gameTries}.");
                    Console.WriteLine("====================================\n");
                }
            }
            Helpers.AddToGameHistory("Subtraction", score);
            Console.WriteLine("Press enter to return to the menu.");
            Console.ReadLine();

        }
        internal void MultiplicationGame(string message)
        {
            Console.WriteLine(message);

            Random randNum = new Random();
            int num1;
            int num2;
            int gameTries = 5;
            int score = 0;

            for (int i = 0; i < gameTries; i++)
            {
                num1 = randNum.Next(1, 9);
                num2 = randNum.Next(1, 9);

                Console.WriteLine($"{num1} * {num2}");

                string? result = Console.ReadLine() ?? "0";

                if (int.Parse(result) == num1 * num2)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }
                if (i == gameTries - 1)
                {
                    Console.WriteLine($"\nGame Over. Your score is {score}/{gameTries}.");
                    Console.WriteLine("====================================\n");
                }
            }
            Helpers.AddToGameHistory("Multiplication", score);
            Console.WriteLine("Press enter to return to the menu.");
            Console.ReadLine();

        }
        internal void DivisionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            int[] numbers = Helpers.GetDivisionNumbers();
            int gameTries = 5;
            int score = 0;

            for (int i = 0; i < gameTries; i++)
            {
                int num1 = numbers[0];
                int num2 = numbers[1];

                Console.WriteLine($"{num1} / {num2}");

                string? result = Console.ReadLine() ?? "0";

                if (int.Parse(result) == num1 / num2)
                {
                    Console.WriteLine("Correct! \n");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect. (Answer: {num1 / num2})\n");
                }
                if (i == gameTries - 1)
                {
                    Console.WriteLine($"\nGame Over. Your score is {score}/{gameTries}.");
                    Console.WriteLine("====================================\n");
                }
                else
                {
                    numbers = Helpers.GetDivisionNumbers();
                }
            }
            Helpers.AddToGameHistory("Division", score);
            Console.WriteLine("Press enter to return to the menu.");
            Console.ReadLine();

        }
    }
}
