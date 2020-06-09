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
    /// Interaction logic for OrderLineWindow.xaml
    /// </summary>
    public partial class OrderLineWindow : Window
    {
        private TargetEntities db;
        public OrderLineWindow()
        {
            InitializeComponent();
        }
        public OrderLineWindow(int? CID)
        {
            db = new TargetEntities();
            InitializeComponent();
            Populate_lvOrderLine(db, CID);

        }

        private void Populate_lvOrderLine(TargetEntities db, int? CID)
        {
            var resultOrderLines = (from result in db.OrderLine
                                 where result.OrderId == CID
                                 select result).ToList();
            lvOrderLine.Items.Clear();
            foreach (OrderLine o in resultOrderLines)
            {
                lvOrderLine.Items.Add(o);
            }
        }

        private void LvOrderLine_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnProductLine_Click(object sender, RoutedEventArgs e)
        {
            ProductWindow prod = new ProductWindow();
            prod.Show();
            this.Hide();
        }

        private void BtnOrders_Click(object sender, RoutedEventArgs e)
        {
            OrdersWindow orders = new OrdersWindow();
            orders.Show();
            this.Hide();
        }

        private void BtnCostumer_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }

        private void BuyProduct_Click(object sender, RoutedEventArgs e)
        {

        }

       
    }
}
