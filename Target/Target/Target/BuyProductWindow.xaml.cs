using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
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
    /// Interaction logic for BuyProductWindow.xaml
    /// </summary>
    public partial class BuyProductWindow : Window
    {
        private TargetEntities db;

       
        public BuyProductWindow()
        {
            db = new TargetEntities();
            InitializeComponent();
            Populate_lvSelectCostumer(db, LvSelectCostumer);

        }

        private void LvDisplayResult(int productCode)
        {
            LvChooseProducts.Items.Clear();
            var query = (from product in db.Products
                         where product.ProductCode == productCode
                         select product);
            foreach (var p in query)
            {
                LvChooseProducts.Items.Add(p);
            }

        }

        private void LvChooseProducts_Click(object sender, MouseButtonEventArgs e)
        {            
            var Lv = (ListView)sender;
            var BP = (Products)Lv.SelectedItem;
            var ProductId = BP.Id;
            var ProductName = BP.ProductName;
            

            var resultProduct = (from result in db.Products
                                 where result.Id == ProductId
                                 select result).Single();
            LvBuyProducts.Items.Add(resultProduct);
            /*var LvBP = LvBuyProducts;
            
            int Sum = 0;
            
            // få fat i objectets pris 
            foreach (var line in LvBP.Items)
            {
                // price er type "int?" som både kan være int og null, 
                // derfor checker vi om den er null og caster den til int
                // caster line til Products da man kan skrive Products.Price
                var price = ((Products)line).Price;
                if (price != null)
                    Sum += (int)price;
            }
            //"{0:C}" currency = skriver kr. 0.00
            txtbSum.Text = String.Format("{0:C}", Sum);
            */
        }
            
        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            
            var LvBP = LvBuyProducts;
            
            int Sum = 0;

            // få fat i objectets pris 
            foreach (var line in LvBP.Items)
            {
                var price = ((Products)line).Price;
                if (price != null)
                    Sum += (int) price;
            }
            //"{0:C}" currency = skriver kr. 0.00
            txtbSum.Text = String.Format("{0:C}", Sum);
        }


        private void Populate_lvSelectCostumer(TargetEntities db, ListView lvSelectCostumer)
        {
            var costumers = db.Costumer.ToList();
            lvSelectCostumer.Items.Clear();
            foreach (Costumer c in costumers)
            {
                lvSelectCostumer.Items.Add(c);
            }
        }
        private void BtnCostumer_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }
               
        private void LvChooseProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

        }       

        private void LvProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnBuy_Click(object sender, RoutedEventArgs e)
        {

            var LvBP = LvBuyProducts;
          
            foreach (var line in LvBP.Items)
            {
                var OL = ((Products)line).Id;
                var orderId = int.Parse(txtbOrderNumber.Text);
                var productid = ((Products)line).ProductCode;

                var testmodel2 = new Orders
                {
                    Id = orderId,                    
                    CostumerId = orderId,

                };

                var testModel = new OrderLine
                {
                    ProductCode = productid,
                    OrderLineProductId = OL,
                    OrderId = orderId,
                    Date = System.DateTime.Now
                };

                
                var update = (from x in db.Orders 
                              where x.Id == orderId 
                             select x).FirstOrDefault();

                if (update == null)
                {
                    db.Orders.Add(testmodel2);
                    db.SaveChanges();

                    db.OrderLine.Add(testModel);
                    db.SaveChanges();
                }
                else
                {
                    db.OrderLine.Add(testModel);
                    db.SaveChanges();
                }
                                  
            }   
        }

        private void ComboBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            LvDisplayResult(5);
        }

        private void ComboBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            LvDisplayResult(4);
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            LvDisplayResult(3);
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            LvDisplayResult(2);

        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            LvDisplayResult(1);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CBI1.IsSelected = true;
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

       
    }
}
