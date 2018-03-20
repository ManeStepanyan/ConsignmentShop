namespace ConsigmentShopUI
{
    partial class ConsignmentShop
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
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemsListBoxLabel = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.shoppingCart = new System.Windows.Forms.Label();
            this.shoppingCartListBox = new System.Windows.Forms.ListBox();
            this.itemPurchase = new System.Windows.Forms.Button();
            this.vendorsListLabel = new System.Windows.Forms.Label();
            this.vendorsListbox = new System.Windows.Forms.ListBox();
            this.storeProfit = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(54, 47);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(344, 31);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop Demo";
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 20;
            this.itemsListBox.Location = new System.Drawing.Point(1, 135);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(207, 124);
            this.itemsListBox.TabIndex = 1;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.itemsListBox_SelectedIndexChanged);
            // 
            // itemsListBoxLabel
            // 
            this.itemsListBoxLabel.AutoSize = true;
            this.itemsListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListBoxLabel.Location = new System.Drawing.Point(26, 112);
            this.itemsListBoxLabel.Name = "itemsListBoxLabel";
            this.itemsListBoxLabel.Size = new System.Drawing.Size(103, 20);
            this.itemsListBoxLabel.TabIndex = 2;
            this.itemsListBoxLabel.Text = "Store Items";
            this.itemsListBoxLabel.Click += new System.EventHandler(this.itemsListBoxLabel_Click);
            // 
            // addToCart
            // 
            this.addToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCart.Location = new System.Drawing.Point(225, 170);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(84, 31);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "Add to cart";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click_1);
            // 
            // shoppingCart
            // 
            this.shoppingCart.AutoSize = true;
            this.shoppingCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCart.Location = new System.Drawing.Point(335, 112);
            this.shoppingCart.Name = "shoppingCart";
            this.shoppingCart.Size = new System.Drawing.Size(121, 20);
            this.shoppingCart.TabIndex = 5;
            this.shoppingCart.Text = "Shopping cart";
            // 
            // shoppingCartListBox
            // 
            this.shoppingCartListBox.FormattingEnabled = true;
            this.shoppingCartListBox.ItemHeight = 20;
            this.shoppingCartListBox.Location = new System.Drawing.Point(339, 135);
            this.shoppingCartListBox.Name = "shoppingCartListBox";
            this.shoppingCartListBox.Size = new System.Drawing.Size(184, 124);
            this.shoppingCartListBox.TabIndex = 4;
            // 
            // itemPurchase
            // 
            this.itemPurchase.Location = new System.Drawing.Point(423, 268);
            this.itemPurchase.Name = "itemPurchase";
            this.itemPurchase.Size = new System.Drawing.Size(89, 26);
            this.itemPurchase.TabIndex = 6;
            this.itemPurchase.Text = "Purchase";
            this.itemPurchase.UseVisualStyleBackColor = true;
            this.itemPurchase.Click += new System.EventHandler(this.itemPurchase_Click);
            // 
            // vendorsListLabel
            // 
            this.vendorsListLabel.AutoSize = true;
            this.vendorsListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorsListLabel.Location = new System.Drawing.Point(37, 296);
            this.vendorsListLabel.Name = "vendorsListLabel";
            this.vendorsListLabel.Size = new System.Drawing.Size(76, 20);
            this.vendorsListLabel.TabIndex = 8;
            this.vendorsListLabel.Text = "Vendors";
            this.vendorsListLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // vendorsListbox
            // 
            this.vendorsListbox.FormattingEnabled = true;
            this.vendorsListbox.ItemHeight = 20;
            this.vendorsListbox.Location = new System.Drawing.Point(1, 319);
            this.vendorsListbox.Name = "vendorsListbox";
            this.vendorsListbox.Size = new System.Drawing.Size(207, 124);
            this.vendorsListbox.TabIndex = 7;
            // 
            // storeProfit
            // 
            this.storeProfit.AutoSize = true;
            this.storeProfit.Location = new System.Drawing.Point(349, 319);
            this.storeProfit.Name = "storeProfit";
            this.storeProfit.Size = new System.Drawing.Size(89, 20);
            this.storeProfit.TabIndex = 9;
            this.storeProfit.Text = "Store Profit";
            this.storeProfit.Click += new System.EventHandler(this.storeProfit_Click);
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitValue.Location = new System.Drawing.Point(444, 319);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(54, 20);
            this.storeProfitValue.TabIndex = 10;
            this.storeProfitValue.Text = "$0:00";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 497);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storeProfit);
            this.Controls.Add(this.vendorsListLabel);
            this.Controls.Add(this.vendorsListbox);
            this.Controls.Add(this.itemPurchase);
            this.Controls.Add(this.shoppingCart);
            this.Controls.Add(this.shoppingCartListBox);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.itemsListBoxLabel);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop Demo";
            this.Load += new System.EventHandler(this.ConsignmentShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label itemsListBoxLabel;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Label shoppingCart;
        private System.Windows.Forms.ListBox shoppingCartListBox;
        private System.Windows.Forms.Button itemPurchase;
        private System.Windows.Forms.Label vendorsListLabel;
        private System.Windows.Forms.ListBox vendorsListbox;
        private System.Windows.Forms.Label storeProfit;
        private System.Windows.Forms.Label storeProfitValue;
    }
}

