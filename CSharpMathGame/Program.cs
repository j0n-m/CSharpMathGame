namespace CSharpMathGame
{
    class Program
    {
        public static List<string> games = new List<string>();

        public static void Main(string[] args)
        {
            DateTime date = DateTime.UtcNow;
            //List<string> games = new List<string>();
            string name = GetName("Please enter your name:");

            Menu(date, name);
        }

        static string GetName(string message)
        {
            Console.WriteLine(message);
            string? name = Console.ReadLine();
            return string.IsNullOrWhiteSpace(name) ? "user" : name;
        }
        static void Menu(DateTime date, string name)
        {
            bool isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Hello, {name.ToUpper()}. It's {date.ToLocalTime().DayOfWeek}. Welcome to the math game.\n");
                ShowGameMessage();

                char mathOption = GetOptionInput();



                switch (mathOption)
                {
                    case 'v':
                        GetGames();
                        break;
                    case 'a':
                        AdditionGame("Addition Selected");
                        break;
                    case 's':
                        SubtractionGame("Subtraction Selection");
                        break;
                    case 'm':
                        MultiplicationGame("Multiplication Selected");
                        break;
                    case 'd':
                        DivisionGame("Division Selected");
                        break;
                    case 'q':
                        Console.WriteLine("\nQuitting the game...");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("\nInvalid option. Please try again.");
                        break;
                }

            } while (isGameOn);

            int gameCount = games.Count;

            if (gameCount > 0)
            {
                Console.WriteLine($"You've completed {gameCount} {(gameCount > 1 ? "games" : "game")}.");

            }

        }
        static void AdditionGame(string message)
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
            games.Add($"{DateTime.Now} - Addition: Score={score}");

            Console.WriteLine("Press enter to return to the menu.");
            Console.ReadLine();

        }

        static void SubtractionGame(string message)
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
            games.Add($"{DateTime.Now} - Subtraction: Score={score}");
            Console.WriteLine("Press enter to return to the menu.");
            Console.ReadLine();

        }
        static void MultiplicationGame(string message)
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
            games.Add($"{DateTime.Now} - Multiplication: Score={score}");
            Console.WriteLine("Press enter to return to the menu.");
            Console.ReadLine();

        }
        static void DivisionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            int[] numbers = GetDivisionNumbers();
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
                    numbers = GetDivisionNumbers();
                }
            }
            games.Add($"{DateTime.Now} - Division: Score={score}");
            Console.WriteLine("Press enter to return to the menu.");
            Console.ReadLine();

        }
        static void ShowGameMessage()
        {
            Console.WriteLine($@"What game would you like to play today? Choose from the options below:
              V - View recent games
              A - Addition
              S - Subtraction
              M - Multiplication
              D - Division
              Q - Quit");
            Console.WriteLine("--------------------------------------------------");

        }
        static int[] GetDivisionNumbers()
        {
            Random random = new Random();
            int num1 = random.Next(0, 99);
            int num2 = random.Next(0, 99);
            int[] result = new int[2];


            while (num2 == 0 || num1 % num2 != 0)
            {
                num1 = random.Next(0, 99);
                num2 = random.Next(0, 99);
            }
            result[0] = num1;
            result[1] = num2;


            return result;
        }

        static char GetOptionInput()
        {
            string? input = Console.ReadLine();
            char mathOption = string.IsNullOrWhiteSpace(input) ? 'l' : input.Trim().ToLower()[0];
            return mathOption;
        }
        static void GetGames()
        {
            Console.Clear();
            if (games.Count == 0)
            {
                Console.WriteLine("You haven't played any games. Press enter to return to the menu.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Here are the games you've recently played:\n");
            Console.WriteLine("---------------------");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("\nPress enter to return to the menu.");
            Console.ReadLine();
        }
    }
}
