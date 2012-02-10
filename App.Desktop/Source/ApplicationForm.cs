using System;
using System.Windows.Forms;
using App.Desktop.Commands;

namespace App.Desktop
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            new WinFormListStockCommand().Execute();
        }
    }
}
