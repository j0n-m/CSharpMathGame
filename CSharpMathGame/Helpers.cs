

using CSharpMathGame.Models;

namespace CSharpMathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>
        {
            //new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
            //new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
            //new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
            //new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
            //new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
            //new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
            //new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
            //new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
            //new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },
        };
        internal static void GetGames()
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
            foreach (Game game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} pts");
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("\nPress enter to return to the menu.");
            Console.ReadLine();
        }
        internal static int[] GetDivisionNumbers()
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
        internal static string GetName(string message)
        {
            Console.WriteLine(message);
            string? name = Console.ReadLine();
            return string.IsNullOrWhiteSpace(name) ? "user" : name;
        }
        internal static void AddToGameHistory(GameType game, int score)
        {
            games.Add(new Game { Date = DateTime.Now, Type = game, Score = score });

        }
        internal static string ValidateNumberInput(string? input)
        {
            while (String.IsNullOrEmpty(input) || !Int32.TryParse(input, out _))
            {
                Console.WriteLine("Input must be a whole number. Try again.");
                input = Console.ReadLine();
            }
            return input;

        }
    }
}
