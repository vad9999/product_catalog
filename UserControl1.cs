using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace product_catalog
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1(Product product)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(product.Path);
            name.Text += product.Name;
            specification.Text += product.Specification;
            fabricator.Text += product.Fabricator.Name;
            price.Text += product.Price.ToString();
            quantity.Text += product.Quantity.ToString();
            if (product.Quantity > 0)
            {
                this.BackColor = Color.LightBlue;
            }
            else
            {
                this.BackColor = Color.Gray;
            }
        }
    }
}
