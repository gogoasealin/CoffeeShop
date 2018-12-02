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
    public partial class CoffeeShopPOS : Form
    {

        private BindingList<TblProduct> products = new BindingList<TblProduct>();
        private CoffeeShopDBEntities cse = new CoffeeShopDBEntities();
        private decimal transactionTotal;

        public decimal TransactionTotal
        {
            get { return transactionTotal; }
            set
            {
                transactionTotal = value;
                txtTotal.Text = String.Format("{0:c}", transactionTotal);
            }
        }


        public CoffeeShopPOS()
        {
            InitializeComponent();

            listProductsChosen.DataSource = products;
            listProductsChosen.DisplayMember = "Description";
            CreateTabbedPanel();
            AddProductsToTabbedPanel();
        }

        private void CreateTabbedPanel()
        {
            foreach(TblProductType pt in cse.TblProductTypes)
            {
                tabControl1.TabPages.Add(pt.ProductType.ToString(), pt.Description);
            }
        }

        private void AddProductsToTabbedPanel()
        {
            int i = 1;
            foreach (TabPage tp in tabControl1.TabPages)
            {
                var filteredProduct = cse.TblProducts.Where(product => product.ProductType.ToString() == i.ToString()).ToList();
                FlowLayoutPanel flp = new FlowLayoutPanel();

                flp.Dock = DockStyle.Fill;

                foreach(TblProduct tprod in filteredProduct)
                {
                    Button b = new Button();
                    b.Size = new Size(100, 100);
                    b.Text = tprod.Description;
                    b.Tag = tprod;
                    b.Click += new EventHandler(UpdateProductList);
                    flp.Controls.Add(b);


                }
                
                tp.Controls.Add(flp);
                i++;
            }
        }

        private void UpdateProductList(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            TblProduct p = (TblProduct)b.Tag;

            products.Add(p);

            UpdateCustomerInformationPanel(p);

            TransactionTotal += (decimal)p.Price;

            listProductsChosen.SelectedIndex = listProductsChosen.Items.Count - 1;

        }

        private void UpdateCustomerInformationPanel(TblProduct product)
        {
            string currentDescription = product.Description;
            string currentPrice = String.Format("{0:c}", product.Price);
            string currentDescriptionPadded = currentDescription.PadRight(10);

            txtInfoPanel.Text = currentDescriptionPadded + currentPrice;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TblProduct p = new TblProduct()
            {
                Description = "product a",
                Price = 1.99M
            };

            products.Add(p);
        }

        private void FormatListItem(object sender, ListControlConvertEventArgs e)
        {
            string currentDescription = ((TblProduct)e.ListItem).Description;
            string currentPrice = String.Format("{0:c}",((TblProduct)e.ListItem).Price);
            string currentDescriptionPadded = currentDescription.PadRight(30);

            e.Value = currentDescriptionPadded + currentPrice;

        }

        private void DeleteItem(object sender, EventArgs e)
        {
            TblProduct selectedProduct = (TblProduct)listProductsChosen.SelectedItem;

            products.Remove(selectedProduct);
        }

        private void OpenPayment(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.ShowDialog();

            payment.PaymentMade += new Payment.PaymentMadeEvent(payment_PaymentMade);

            payment.PaymentAmount = TransactionTotal;
        }

        void payment_PaymentMade(object sender, PaymentMadeEventArgs e)
        {
            MessageBox.Show(e.PaymentSuccess.ToString());
        }
    }
}
