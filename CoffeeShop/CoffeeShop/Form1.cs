using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();                 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();

            addProduct.Show();
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            ViewProduct viewProduct = new ViewProduct();

            viewProduct.Show();
        }

        private void btnOpenPOS_Click(object sender, EventArgs e)
        {
            CoffeeShopPOS coffeeShopPOS = new CoffeeShopPOS();

            coffeeShopPOS.Show();
        }
    }
}
