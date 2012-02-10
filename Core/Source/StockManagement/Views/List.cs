using Core.StockManagement.Presenters;

namespace Core.StockManagement.Views
{
    public interface List
    {
        void SetPresenter(StockPresenter presenter);
        void Render();
    }
}