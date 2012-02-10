using Core.StockManagement.Controllers;
using Core.StockManagement.Views;

namespace Core.StockManagement.Commands
{
    public abstract class ListStockCommand
    {
        public abstract ViewFactory CreateViewFactory();

        public void Execute()
        {
            new StockController(CreateViewFactory()).List();
        }
    }
}

