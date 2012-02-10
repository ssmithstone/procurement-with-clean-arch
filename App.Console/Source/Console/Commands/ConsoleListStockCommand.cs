using Core.StockManagement.Commands;
using Core.StockManagement.Views;

namespace App.Console.Console.Commands
{
    public class ConsoleListStockCommand : ListStockCommand
    {
        public override ViewFactory CreateViewFactory()
        {
            return new ConsoleStockViewFactory();
        }

    }
}