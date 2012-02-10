using Core.StockManagement.Presenters;
using Core.StockManagement.Views;

namespace Core.StockManagement.Controllers
{
    public class StockController
    {
        private readonly ViewFactory _viewFactory;

        public StockController(ViewFactory viewFactory)
        {
            _viewFactory = viewFactory;
        }

        public void List()
        {
            var view = _viewFactory.CreateListView();
            view.SetPresenter(GetStockPresenter());
            view.Render();
        }

        public virtual StockPresenter GetStockPresenter()
        {
            return new StockPresenter();
        }

    }
}