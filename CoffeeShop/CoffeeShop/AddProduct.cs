using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class AddProduct : Form
    {
        CoffeeShopDBEntities cse = new CoffeeShopDBEntities();
        private Byte[] byteBLOBData; 

        public AddProduct()
        {
            InitializeComponent();
            Init();

        }

        void Init()
        {
            boxCategory.DataSource = (cse.TblProductTypes).ToList();
            boxCategory.DisplayMember = "Description";
            boxCategory.ValueMember = "ProductType";
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                FileStream fsBLOBFile = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                byteBLOBData = new Byte[fsBLOBFile.Length];

                fsBLOBFile.Read(byteBLOBData, 0, byteBLOBData.Length);

                fsBLOBFile.Close();

                MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);

                pbImage.Image = Image.FromStream(stmBLOBData);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TblProduct product = new TblProduct();

            product.Description = txtDescription.Text;

            product.Price = decimal.Parse(txtPrice.Text);

            product.Image = byteBLOBData;

            product.ProductType = (int)boxCategory.SelectedValue;

            cse.TblProducts.Add(product);
            cse.SaveChanges();

            MessageBox.Show("Record Save");
        }
    }
}
