namespace CoffeeShop
{
    partial class CoffeeShopPOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoffeeShopPOS));
            this.listProductsChosen = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.txtInfoPanel = new System.Windows.Forms.TextBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listProductsChosen
            // 
            this.listProductsChosen.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listProductsChosen.FormattingEnabled = true;
            this.listProductsChosen.ItemHeight = 17;
            this.listProductsChosen.Location = new System.Drawing.Point(655, 12);
            this.listProductsChosen.Name = "listProductsChosen";
            this.listProductsChosen.Size = new System.Drawing.Size(344, 446);
            this.listProductsChosen.TabIndex = 0;
            this.listProductsChosen.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.FormatListItem);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(33, 109);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(545, 349);
            this.tabControl1.TabIndex = 2;
            // 
            // txtInfoPanel
            // 
            this.txtInfoPanel.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoPanel.Location = new System.Drawing.Point(33, 40);
            this.txtInfoPanel.Name = "txtInfoPanel";
            this.txtInfoPanel.Size = new System.Drawing.Size(545, 38);
            this.txtInfoPanel.TabIndex = 3;
            this.txtInfoPanel.Text = "Next Customer";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(655, 478);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(144, 84);
            this.btnDeleteItem.TabIndex = 4;
            this.btnDeleteItem.Text = "&Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.DeleteItem);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Lime;
            this.btnPay.Location = new System.Drawing.Point(33, 478);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(545, 71);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.OpenPayment);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(819, 478);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(180, 22);
            this.txtTotal.TabIndex = 6;
            // 
            // CoffeeShopPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 614);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.txtInfoPanel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listProductsChosen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CoffeeShopPOS";
            this.Text = "CoffeeShopPOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listProductsChosen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtInfoPanel;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtTotal;
    }
}