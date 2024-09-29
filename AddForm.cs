using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace product_catalog
{
    public partial class AddForm : Form
    {
        bool addpic = false;
        public event EventHandler<string> FabricatorAdded;
        public AddForm()
        {
            InitializeComponent();
            
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameBox.Text) ||
                string.IsNullOrEmpty(SpecificationBox.Text) ||
                string.IsNullOrEmpty(FabricatorBox.Text) ||
                string.IsNullOrEmpty(PriceBox.Text) ||
                string.IsNullOrEmpty(QuantityBox.Text))
            {
                MessageBox.Show("Пожалуйста заполните все поля.");
                return;
            }

            double price;
            if (!double.TryParse(PriceBox.Text, out price))
            {
                MessageBox.Show("Цена должна быть указана цифрами.");
                return;
            }

            int quantity;
            if (!int.TryParse(QuantityBox.Text, out quantity))
            {
                MessageBox.Show("Количество должно быть целым числом.");
                return;
            }
            if (!addpic)
            {
                MessageBox.Show("Добавьте фотографию.");
            }
            else 
            {
                string fabricatorName = FabricatorBox.Text;
                Fabricator fabricator;
                using (var context = new MyDbContext())
                {
                    fabricator = context.Fabricators.FirstOrDefault(m => m.Name == fabricatorName);

                    if (fabricator == null)
                    {
                        fabricator = new Fabricator { Name = fabricatorName };
                        context.Fabricators.Add(fabricator);
                    }

                    string productName = NameBox.Text;
                    bool productExists = context.Products.Any(p => p.Name == productName);

                    if (productExists)
                    {
                        MessageBox.Show("Продукт с таким именем уже добавлен.");
                        return;
                    }

                    Product product = new Product
                    {
                        Name = productName,
                        Specification = SpecificationBox.Text,
                        Path = openFileDialog1.FileName,
                        Price = price,
                        Fabricator = fabricator,
                        Quantity = quantity
                    };

                    context.Products.Add(product);

                    try
                    {
                        context.SaveChanges();
                        MessageBox.Show("Продукт добавлен.");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            } 
        }

        private void AddImgButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                addpic = true;
                return;
        }
    }
}
