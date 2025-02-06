namespace CSharpMathGame.Models
{
    internal class Game
    {
        internal int Score { get; set; }
        internal DateTime Date { get; set; }
        internal required GameType Type { get; set; }


    }
    internal enum GameType
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }

}
