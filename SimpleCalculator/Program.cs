namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInput ui = new UserInput();
            Addition add = new Addition();
            add.AddNumbers(ui.GetNumber(), ui.GetNumber());
            add.AddNumbers(ui.GetFloatNumber(), ui.GetFloatNumber());
            Console.ReadKey();
        }
    }
}
