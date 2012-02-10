using Core.StockManagement.Views;

namespace App.Console.Console.Views
{
    public class ConsoleListView : AbstractListView
    {

        public override void Render()
        {
            System.Console.WriteLine("Stock List View (Console Mode)");    
        }
    }
}