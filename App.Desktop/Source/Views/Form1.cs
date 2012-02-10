using System.Windows.Forms;
using Core.StockManagement.Presenters;
using Core.StockManagement.Views;

namespace App.Desktop
{
    public partial class Form1 : Form , List
    {
        private StockPresenter _presenter;

        public Form1()
        {
            InitializeComponent();
        }

        public void SetPresenter(StockPresenter presenter)
        {
            this._presenter = presenter;
        }

        public void Render()
        {
            Show();
        }
    }
}
