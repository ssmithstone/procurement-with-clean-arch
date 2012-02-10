using App.Console.Console.Commands;

namespace App.Console
{
    class Program
    {
        static void Main(string[] args)
        {
             new ConsoleListStockCommand().Execute();
        }
    }
}
