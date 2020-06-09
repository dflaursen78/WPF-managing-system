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
    /// Interaction logic for CostumerSelectWindow.xaml
    /// </summary>
    public partial class CostumerSelectWindow : Window
    {
        public CostumerSelectWindow()
        {
            InitializeComponent();
        }

        private void BtnCostumer_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }

        private void BtnCreateOrder_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void LvCostumers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
