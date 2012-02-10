using Core.StockManagement.Views;

namespace App.Desktop.Views
{
    public class WinFormStockViewFactory : ViewFactory
    {
        public override List CreateListView()
        {
            return new Form1();
        }
    }
}