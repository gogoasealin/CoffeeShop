using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class ViewProduct : Form
    {
        private CoffeeShopDBEntities cse = new CoffeeShopDBEntities();

        public ViewProduct()
        {
            InitializeComponent();

            dataGridView1.DataSource = cse.TblProducts.ToList();

            dataGridView1.Columns["ProductType"].Visible = false;

            cbFilter.DataSource = cse.TblProductTypes.ToList();
            cbFilter.DisplayMember = "Description";
            cbFilter.ValueMember = "ProductType";


        }

        private void FilterList(object sender, EventArgs e)
        {

            //var products = cse.TblProducts.ToList();

            //var query = from product in products
            //            where product.ProductType.ToString() == cbFilter.SelectedValue.ToString()
            //            select product;
            var filteredProduct = cse.TblProducts.Where(x => x.ProductType.ToString() == cbFilter.SelectedValue.ToString()).ToList();

            dataGridView1.DataSource = filteredProduct;
        }
    }
}
