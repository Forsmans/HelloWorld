namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, World!");
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Bye, World");
            Console.ResetColor();

        }
    }
}