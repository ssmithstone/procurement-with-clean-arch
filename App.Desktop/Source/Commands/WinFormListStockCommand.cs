using App.Desktop.Views;
using Core.StockManagement.Commands;
using Core.StockManagement.Views;

namespace App.Desktop.Commands
{
    public class WinFormListStockCommand : ListStockCommand
    {
        public override ViewFactory CreateViewFactory()
        {
            return new WinFormStockViewFactory();
            
        }


    }
}