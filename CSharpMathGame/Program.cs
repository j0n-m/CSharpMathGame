namespace CSharpMathGame
{
    class Program
    {

        public static void Main(string[] args)
        {
            DateTime date = DateTime.UtcNow;
            Menu menu = new Menu();

            string name = Helpers.GetName("Please enter your name:");
            menu.ShowMenu(date, name);
        }



    }
}
