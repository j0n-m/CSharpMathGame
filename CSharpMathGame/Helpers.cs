

using CSharpMathGame.Models;

namespace CSharpMathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new();
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
                Console.WriteLine($"{game.Date} - {game.GameType}: {game.Score} pts");
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
        internal static void AddToGameHistory(string gameName, int score)
        {
            //games.Add(new Game { Date = DateTime.Now, GameType = gameName, Score = score });
            games.Add(new Game { Date = DateTime.Now, GameType = gameName, Score = score });

        }
    }
}
