using App.Console.Console.Views;
using Core.StockManagement.Views;

namespace App.Console.Console
{
    public class ConsoleStockViewFactory : ViewFactory
    {
        public override List CreateListView()
        {
            return new ConsoleListView();
        }
    }
}