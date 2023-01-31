using ConsignmentShopLibrary;
namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store("Better Books");
        private List<Item> shoppingCart = new List<Item>();
        BindingSource shopItemsBinding = new();
        BindingSource cartItemsBinding = new();
        BindingSource vendorsBinding = new();

        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            shopItemsBinding.DataSource = store.Items;
            ShopItemsListBox.DataSource = shopItemsBinding;

            ShopItemsListBox.DisplayMember = "Display";
            ShopItemsListBox.ValueMember = "Display";

            cartItemsBinding.DataSource = shoppingCart;
            CartListItems.DataSource = cartItemsBinding;

            CartListItems.DisplayMember = "Display";
            CartListItems.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            VendorsListBox.DataSource = vendorsBinding;

            VendorsListBox.DisplayMember = "Display";
            VendorsListBox.ValueMember = "Display";
        }

        public void SetupData()
        {
            store.Vendors.Add(new Vendor("Tinashe", "Muchineripi")
            {
                Items = store.Items.Where(item => item.Owner.FullName == "Tinashe Muchineripi").ToList()
            });
            store.Vendors.Add(new Vendor("Takudzwa", "Muchineripi")
            {
                Items = store.Items.Where(item => item.Owner.FullName == "Takudzwa Muchineripi").ToList()
            });

            store.Items.Add(new Item("Head First C#", "A book that will teach you how to write code in C#")
            {
                Price = 85.50M,
                Owner = store.Vendors[0],
            });

            store.Items.Add(new Item("Head First Java", "A book that will teach you how to write code in Java")
            {
                Price = 75.50M,
                Owner = store.Vendors[1],
            });
            
            store.Items.Add(new Item("Head First HTML", "A book that will teach you how to write code in HTML")
            {
                Price = 95.50M,
                Owner = store.Vendors[1],
            });

            store.Items.Add(new Item("Head First TypeScript", "A book that will teach you how to write code in TypeScript")
            {
                Price = 25.50M,
                Owner = store.Vendors[0],
            });
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            //find the item highlighted
            //Add the selected item to the shopping cart.
            shoppingCart.Add((Item)ShopItemsListBox.SelectedItem);

            MessageBox.Show($"{ShopItemsListBox.SelectedItem.ToString()} has been added to the Cart.");
            cartItemsBinding.ResetBindings(false);
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            //mark selected items as sold 
            //clear the cart
            foreach (Item item in shoppingCart)
            {
                item.Sold = true;
                item.Owner.PaymentDue += item.Price * (decimal)item.Owner.Commision;
                store.Profit += (decimal)(1 - item.Owner.Commision) * item.Price;
            }
            shopItemsBinding.DataSource = store.Items.Where(item => item.Sold == true);

            StoreProfitValue.Text = String.Format("{0:c}", store.Profit);
            shoppingCart.Clear();
            cartItemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
            shopItemsBinding.ResetBindings(false);
        }

        
    }
}