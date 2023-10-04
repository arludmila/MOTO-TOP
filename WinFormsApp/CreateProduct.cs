using Contracts.DTOs.Entities;
using Contracts.Utils;
using Entities.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class CreateProduct : Form
    {
        public CreateProduct()
        {
            InitializeComponent();
        }

        private async void buttonCreateProduct_Click(object sender, EventArgs e)
        {
            Category selectedCategory = (Category)comboBoxCategories.SelectedItem;
            int categoryId = 0;
            if (selectedCategory != null)
            {
                // Access the Id property of the selected Category
                categoryId = selectedCategory.Id;

            }
            var product = new ProductDto()
            {
                Name = txtBoxName.Text,
                Description = txtBoxDescription.Text,
                Price = Convert.ToDouble(txtBoxPrice.Text),
                Quantity = Convert.ToInt32(txtBoxQuantity.Text),
                CategoryId = categoryId,
            };
            await ApiHelper.PostAsync("https://localhost:7215/api/products", product);
            this.Close();
        }

        private async void CreateProduct_Load(object sender, EventArgs e)
        {
            var categories = await ApiHelper.GetAsync<Category>("https://localhost:7215/api/categories");
            if (categories != null)
            {
                comboBoxCategories.DataSource = new BindingList<Category>(categories);
                comboBoxCategories.DisplayMember = "Name";
                comboBoxCategories.ValueMember = "Id";
            }
            
        }
    }
}
