using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsignmentShopLibrary;


namespace ConsigmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> ShoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal ProfitOfStore = 0;
        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            itemsListBox.DataSource = itemsBinding;
            itemsListBox.DisplayMember = "Display";
            itemsListBox.ValueMember = "Display";
            cartBinding.DataSource = ShoppingCartData;
            shoppingCartListBox.DataSource = cartBinding;
            shoppingCartListBox.DisplayMember = "Display";
            shoppingCartListBox.ValueMember = "Display";
            vendorsBinding.DataSource = store.Vendors;
            vendorsListbox.DataSource = vendorsBinding;
            vendorsListbox.DisplayMember = "Display";
            vendorsListbox.ValueMember = "Display";
        }
        private void SetupData()
        {
            store.Vendors.Add(new Vendor { FirstName = "Francis Scott", LastName = "Fitzgerald", Commission = .11 });
            store.Vendors.Add(new Vendor { FirstName = "Charlotte", LastName = "Bronte" });
            store.Vendors.Add(new Vendor { FirstName = "Daniel", LastName = "Keys" });
            store.Vendors.Add(new Vendor { FirstName = "Somerset", LastName = "Moem" });
            store.Items.Add(new Item
            {
                Title = "Flowers for Algernone",
                Description = "A science fixtion",
                Price = 2.50M,
                Owner = store.Vendors[2]
            });
            store.Items.Add(new Item
            {
                Title = "The Great Gatsby",
                Description = "Fitzeralds's book",
                Price = 3.50M,
                Owner = store.Vendors[0]
            });
            store.Items.Add(new Item
            {
                Title = "Theatre",
                Description = " Frence writer Somerset Moem's book",
                Price = 2.0M,
                Owner = store.Vendors[3]
            });
            store.Items.Add(new Item
            {
                Title = "Jane Eyre",
                Description = "Charlotte Bronte's book",
                Price = 1.50M,
                Owner = store.Vendors[1]
            });
            store.Name = "Bookshop";

        }

        private void ConsignmentShop_Load(object sender, EventArgs e)
        {

        }

        private void itemPurchase_Click(object sender, EventArgs e)
        {//foreach( Item item in ShoppingCartData)
            Item selectedItemInCart = (Item)shoppingCartListBox.SelectedItem;
            selectedItemInCart.Sold = true;
            selectedItemInCart.Owner.PaymentDue += (decimal)(selectedItemInCart.Owner.Commission) * selectedItemInCart.Price;
           ProfitOfStore+= (1 -(decimal)(selectedItemInCart.Owner.Commission)) * selectedItemInCart.Price;
            ShoppingCartData.Remove(selectedItemInCart);
           // ShoppingCartData.Clear();
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            storeProfitValue.Text = string.Format("${0}", ProfitOfStore);
            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
             
        }

        private void addToCart_Click_1(object sender, EventArgs e)
        {
            Item selectedItem = (Item)itemsListBox.SelectedItem;
            //MessageBox.Show(selectedItem.Title);
            ShoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void itemsListBoxLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void storeProfit_Click(object sender, EventArgs e)
        {

        }
    }
}
