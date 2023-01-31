namespace ConsignmentShopUI
{
    partial class ConsignmentShop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConsignmentShopLabel = new System.Windows.Forms.Label();
            this.ListItemsLabel = new System.Windows.Forms.Label();
            this.ShopItemsListBox = new System.Windows.Forms.ListBox();
            this.CartListItems = new System.Windows.Forms.ListBox();
            this.CartListLabel = new System.Windows.Forms.Label();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.PurchaseButton = new System.Windows.Forms.Button();
            this.VendorsListBox = new System.Windows.Forms.ListBox();
            this.VendorsListLabel = new System.Windows.Forms.Label();
            this.StoreProfitLabel = new System.Windows.Forms.Label();
            this.StoreProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConsignmentShopLabel
            // 
            this.ConsignmentShopLabel.AutoSize = true;
            this.ConsignmentShopLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConsignmentShopLabel.Location = new System.Drawing.Point(12, 32);
            this.ConsignmentShopLabel.Name = "ConsignmentShopLabel";
            this.ConsignmentShopLabel.Size = new System.Drawing.Size(285, 41);
            this.ConsignmentShopLabel.TabIndex = 1;
            this.ConsignmentShopLabel.Text = "Consignment Shop";
            // 
            // ListItemsLabel
            // 
            this.ListItemsLabel.AutoSize = true;
            this.ListItemsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListItemsLabel.Location = new System.Drawing.Point(27, 93);
            this.ListItemsLabel.Name = "ListItemsLabel";
            this.ListItemsLabel.Size = new System.Drawing.Size(139, 25);
            this.ListItemsLabel.TabIndex = 2;
            this.ListItemsLabel.Text = "Shop Items List";
            // 
            // ShopItemsListBox
            // 
            this.ShopItemsListBox.FormattingEnabled = true;
            this.ShopItemsListBox.ItemHeight = 20;
            this.ShopItemsListBox.Location = new System.Drawing.Point(31, 131);
            this.ShopItemsListBox.Name = "ShopItemsListBox";
            this.ShopItemsListBox.Size = new System.Drawing.Size(300, 184);
            this.ShopItemsListBox.TabIndex = 3;
            // 
            // CartListItems
            // 
            this.CartListItems.FormattingEnabled = true;
            this.CartListItems.ItemHeight = 20;
            this.CartListItems.Location = new System.Drawing.Point(450, 131);
            this.CartListItems.Name = "CartListItems";
            this.CartListItems.Size = new System.Drawing.Size(300, 184);
            this.CartListItems.TabIndex = 5;
            // 
            // CartListLabel
            // 
            this.CartListLabel.AutoSize = true;
            this.CartListLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CartListLabel.Location = new System.Drawing.Point(446, 93);
            this.CartListLabel.Name = "CartListLabel";
            this.CartListLabel.Size = new System.Drawing.Size(98, 25);
            this.CartListLabel.TabIndex = 4;
            this.CartListLabel.Text = "Cart Items";
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddToCartButton.Location = new System.Drawing.Point(209, 343);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(122, 29);
            this.AddToCartButton.TabIndex = 6;
            this.AddToCartButton.Text = "Add To Cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PurchaseButton.Location = new System.Drawing.Point(656, 343);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(94, 29);
            this.PurchaseButton.TabIndex = 7;
            this.PurchaseButton.Text = "Purchase";
            this.PurchaseButton.UseVisualStyleBackColor = true;
            this.PurchaseButton.Click += new System.EventHandler(this.PurchaseButton_Click);
            // 
            // VendorsListBox
            // 
            this.VendorsListBox.FormattingEnabled = true;
            this.VendorsListBox.ItemHeight = 20;
            this.VendorsListBox.Location = new System.Drawing.Point(31, 414);
            this.VendorsListBox.Name = "VendorsListBox";
            this.VendorsListBox.Size = new System.Drawing.Size(300, 184);
            this.VendorsListBox.TabIndex = 9;
            // 
            // VendorsListLabel
            // 
            this.VendorsListLabel.AutoSize = true;
            this.VendorsListLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VendorsListLabel.Location = new System.Drawing.Point(27, 376);
            this.VendorsListLabel.Name = "VendorsListLabel";
            this.VendorsListLabel.Size = new System.Drawing.Size(115, 25);
            this.VendorsListLabel.TabIndex = 8;
            this.VendorsListLabel.Text = "Vendors List";
            // 
            // StoreProfitLabel
            // 
            this.StoreProfitLabel.AutoSize = true;
            this.StoreProfitLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StoreProfitLabel.Location = new System.Drawing.Point(450, 376);
            this.StoreProfitLabel.Name = "StoreProfitLabel";
            this.StoreProfitLabel.Size = new System.Drawing.Size(117, 25);
            this.StoreProfitLabel.TabIndex = 10;
            this.StoreProfitLabel.Text = "Store Profit :";
            // 
            // StoreProfitValue
            // 
            this.StoreProfitValue.AutoSize = true;
            this.StoreProfitValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StoreProfitValue.Location = new System.Drawing.Point(581, 376);
            this.StoreProfitValue.Name = "StoreProfitValue";
            this.StoreProfitValue.Size = new System.Drawing.Size(46, 25);
            this.StoreProfitValue.TabIndex = 11;
            this.StoreProfitValue.Text = "0.00";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 619);
            this.Controls.Add(this.StoreProfitValue);
            this.Controls.Add(this.StoreProfitLabel);
            this.Controls.Add(this.VendorsListBox);
            this.Controls.Add(this.VendorsListLabel);
            this.Controls.Add(this.PurchaseButton);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.CartListItems);
            this.Controls.Add(this.CartListLabel);
            this.Controls.Add(this.ShopItemsListBox);
            this.Controls.Add(this.ListItemsLabel);
            this.Controls.Add(this.ConsignmentShopLabel);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label ConsignmentShopLabel;
        private Label ListItemsLabel;
        private ListBox ShopItemsListBox;
        private ListBox CartListItems;
        private Label CartListLabel;
        private Button AddToCartButton;
        private Button PurchaseButton;
        private ListBox VendorsListBox;
        private Label VendorsListLabel;
        private Label StoreProfitLabel;
        private Label StoreProfitValue;
    }
}