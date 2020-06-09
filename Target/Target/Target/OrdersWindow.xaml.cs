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
    /// Interaction logic for OrdersWindow.xaml
    /// </summary>
    public partial class OrdersWindow : Window
    {
        private TargetEntities db;

        public OrdersWindow()
        {
            db = new TargetEntities();
            InitializeComponent();
            Populate_lvOrders(db, lvOrders);

        }

        private void Populate_lvOrders(TargetEntities db, ListView lvOrders)
        {
            var orders = db.Orders.ToList();
            Console.WriteLine(orders);
            lvOrders.Items.Clear();
            foreach (Orders o in orders)
            {
                lvOrders.Items.Add(o);
            }
        }


        private void LvOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }              

        private void BtnProductList_Click(object sender, RoutedEventArgs e)
        {
            ProductWindow prod = new ProductWindow();
            prod.Show();
            this.Hide();
        }
                       
        private void BtnOrderLine_Click(object sender, RoutedEventArgs e)
        {            
            var LVO = (Orders)lvOrders.SelectedItem;
            var CID = LVO.CostumerId;
                               
            OrderLineWindow orderLine = new OrderLineWindow(CID);
            orderLine.Show();
            this.Hide();
        }

        private void BtnCostumer_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }

        
        /*
        private void BuyProduct_Click(object sender, RoutedEventArgs e)
        {

        }
        */
    }
}
