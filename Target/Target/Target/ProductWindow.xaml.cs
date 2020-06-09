using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Target
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        private TargetEntities db;


        private void Populate_lvProducts(TargetEntities db, ListView lvProducts)
        {
            var product = db.Products.ToList();
            lvProducts.Items.Clear();
            foreach (Products p in product)
            {
                lvProducts.Items.Add(p);
            }
        }

        private void ClearGUI()
        {
            txtbProductName.Clear();
            txtbProductCode.Clear();
            txtbPrice.Clear();
        }

        private void ValidateInputAndApply(Func<String, int, int, int> func)
        {
            bool errorFound = false;
            int productCode = 0, price = 0;
            // tester om der er noget i text boxene
            if (Utilities.IsNotSetCorrect(txtbProductName.Text))
            {
                errorFound = true;
                txtbProductName.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            else
            {
                txtbProductName.ClearValue(TextBox.BorderBrushProperty);
            }

            if (Utilities.IsNotSetCorrect(txtbProductCode.Text))
            {
                errorFound = true;
                txtbProductCode.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            else
            {
                try
                {
                    productCode = int.Parse(txtbProductCode.Text);
                    txtbProductCode.ClearValue(TextBox.BorderBrushProperty);
                }
                catch
                {
                    errorFound = true;
                    txtbPrice.BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }

            if (Utilities.IsNotSetCorrect(txtbPrice.Text))
            {
                errorFound = true;
                txtbPrice.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            else
            {
                try
                {
                    price = int.Parse(txtbProductCode.Text);
                    txtbPrice.ClearValue(TextBox.BorderBrushProperty);
                }
                catch
                {
                    errorFound = true;
                    txtbPrice.BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }

            if (errorFound == false)
            {

                try
                {
                    price = int.Parse(txtbPrice.Text);
                }
                catch
                {
                    errorFound = true;
                    txtbPrice.BorderBrush = new SolidColorBrush(Colors.Red);
                }

            }
            if (errorFound)
            {
                MessageBox.Show("Input Error");
                return;
            }
            // alle tests gennemført

            func(txtbProductName.Text, productCode, price);
        }

        private int Create_Products(String productName, int productCode, int price)
        {
            Products products = new Products();

            products.ProductName = productName;

            products.ProductCode = productCode;

            products.Price = price;

            db.Products.Add(products);
            db.SaveChanges();
            Populate_lvProducts(db, lvProducts);
            ClearGUI();
            return 1;
        }

        private int Update_Products(String productName, int productCode, int price)
        {
            Products products = (Products)lvProducts.SelectedItem;

            products.ProductName = productName;

            products.ProductCode = productCode;

            products.Price = price;

            db.SaveChanges();
            Populate_lvProducts(db, lvProducts);
            ClearGUI();
            return 1;
        }

        private void Delete_Products()
        {
            Products selected = (Products)lvProducts.SelectedItem;
            db.Products.Remove(selected);
            db.SaveChanges();
            Populate_lvProducts(db, lvProducts);
            ClearGUI();
        }

        public ProductWindow()
        {
            InitializeComponent();
            // ClearGUI();
            db = new TargetEntities();
            Populate_lvProducts(db, lvProducts);
        }

        private void Event_btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            ValidateInputAndApply(Create_Products);
        }

        private void Event_btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            ValidateInputAndApply(Update_Products);
        }

        private void Event_btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Delete_Products();
        }

        /*
         * private void Event_tbProductName_KeyUp(object sender, KeyEventArgs e)
         * {
         * if(e.Key = Key.Enter)
         * {
         * create_Products();
         * }
         * }
         */

        private void LvProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvProducts.SelectedItems.Count != 1)
            {
                return;
            }
            Products selected = (Products)lvProducts.SelectedItem;
            txtbProductName.Text = selected.ProductName;
            txtbProductCode.Text = selected.ProductCode.ToString();
            txtbPrice.Text = selected.Price.ToString();

        }

        private void Event_btnCostumer_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }

        private void Event_btnOrder_Click(object sender, RoutedEventArgs e)
        {
            OrdersWindow orders = new OrdersWindow();
            orders.Show();
            this.Hide();
        }

        private void Event_btnOrderLine_Click(object sender, RoutedEventArgs e)
        {
            OrderLineWindow orderLine = new OrderLineWindow();
            orderLine.Show();
            this.Hide();
        }

        private void Event_btnBuyProduct_Click(object sender, RoutedEventArgs e)
        {
             BuyProductWindow buyprod = new BuyProductWindow();
            buyprod.Show();
            this.Hide();
        }
    }
}
