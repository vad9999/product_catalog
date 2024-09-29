using Microsoft.EntityFrameworkCore;
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
    public partial class MainForm : Form
    {
        private List<Product> filteredProducts; 
        private int currentPage = 1;             
        private int productsPerPage = 4;        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                context.Database.EnsureCreated();

                var products = context.Products.Include(p => p.Fabricator).ToList();

                foreach (var product in products)
                {
                    var productControl = new UserControl1(product);
                    FieldProducts.Controls.Add(productControl);
                }
                ProductFilt.Items.Clear();
                ProductFilt.Items.Add("All");
                ProductFilt.SelectedIndex = 0;
                foreach (var fabricator in context.Fabricators)
                {

                    ProductFilt.Items.Add($"{fabricator.Name}");
                }
            }
            Sort.Items.Add("Название");
            Sort.Items.Add("Возрастание цены");
            Sort.Items.Add("Убывание цены");
            Sort.Items.Add("Возрастание количества");
            Sort.Items.Add("Убывание количества");
            Sort.Items.Add("Производитель");
        }

        private void LoadProducts()
        {
            using (var context = new MyDbContext())
            {
                var query = context.Products.Include(p => p.Fabricator).AsQueryable();

                if (ProductFilt.SelectedIndex > 0) 
                {
                    string selectedManufacturer = ProductFilt.SelectedItem.ToString();
                    query = query.Where(p => p.Fabricator.Name == selectedManufacturer);
                }

                string searchname = Search.Text.Trim();
                if (!string.IsNullOrEmpty(searchname))
                {
                    query = query.Where(p => p.Name.Contains(searchname));
                }

                string sortField = Sort.SelectedItem?.ToString();
                switch (sortField)
                {
                    case "Название":
                        query = query.OrderBy(p => p.Name);
                        break;
                    case "Возрастание цены":
                        query = query.OrderBy(p => p.Price);
                        break;
                    case "Убывание цены":
                        query = query.OrderByDescending(p => p.Price);
                        break;
                    case "Возрастание количества":
                        query = query.OrderBy(p => p.Quantity);
                        break;
                    case "Убывание количества":
                        query = query.OrderByDescending(p => p.Quantity);
                        break;
                    case "Производитель":
                        query = query.OrderBy(p => p.Fabricator.Name);
                        break;
                    default:
                        query = query.OrderBy(p => p.Name);
                        break;
                }

                int skipAmount = (currentPage - 1) * productsPerPage;
                query = query.Skip(skipAmount).Take(productsPerPage);

                filteredProducts = query.ToList();
                FieldProducts.Controls.Clear();

                foreach (var product in filteredProducts)
                {
                    var productControl = new UserControl1(product);
                    FieldProducts.Controls.Add(productControl);
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddButon_Click(object sender, EventArgs e)
        {
            AddForm add_form = new AddForm();
            add_form.ShowDialog();
            LoadProducts();
            using (var context = new MyDbContext())
            {
                ProductFilt.Items.Clear();
                ProductFilt.Items.Add("All"); 
                ProductFilt.SelectedIndex = 0;

                foreach (var manufacturer in context.Fabricators)
                {

                    ProductFilt.Items.Add($"{manufacturer.Name}");
                }
            }
        }

        private void ProductFilt_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void Sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadProducts();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                int maxPage = (int)Math.Ceiling((double)context.Products.Count() / productsPerPage);
                if (currentPage < maxPage)
                {
                    currentPage++;
                    LoadProducts();
                }
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
