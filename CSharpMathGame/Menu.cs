
namespace CSharpMathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu(DateTime date, string name)
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
                        Helpers.GetGames();
                        break;
                    case 'a':
                        gameEngine.AdditionGame("Addition Selected");
                        break;
                    case 's':
                        gameEngine.SubtractionGame("Subtraction Selection");
                        break;
                    case 'm':
                        gameEngine.MultiplicationGame("Multiplication Selected");
                        break;
                    case 'd':
                        gameEngine.DivisionGame("Division Selected");
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



        }
        internal void ShowGameMessage()
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
        internal char GetOptionInput()
        {
            string? input = Console.ReadLine();
            char mathOption = string.IsNullOrWhiteSpace(input) ? 'l' : input.Trim().ToLower()[0];
            return mathOption;
        }
    }

}
