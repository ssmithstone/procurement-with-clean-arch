using Core.StockManagement.Presenters;

namespace Core.StockManagement.Views
{
    public abstract class AbstractListView : List
    {
        protected StockPresenter StockPresenter;

        public void SetPresenter(StockPresenter presenter)
        {
            StockPresenter = presenter;
        }

        public abstract void Render();
    }
}