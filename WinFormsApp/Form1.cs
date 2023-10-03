using Contracts.Utils;
using Entities.Core;
using System.ComponentModel;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnProducts_Click(object sender, EventArgs e)
        {
            List<Product> products = await ApiHelper.GetAsync<Product>("https://localhost:7215/api/Products");
            if (products != null)
            {
                poisonDataGridView1.DataSource = new BindingList<Product>(products);
            }
        }
    }
}