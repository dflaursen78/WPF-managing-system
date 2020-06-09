using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Target
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TargetEntities db;

        private void Populate_lvCostumer(TargetEntities db, ListView lvCostumer)
        {
            var costumers = db.Costumer.ToList();
            lvCostumer.Items.Clear();
            foreach(Costumer c in costumers)
            {
               lvCostumer.Items.Add(c);
            }
        }

        //Fjerner alt der er i tekstboxene 
        private void ClearGUI()
        {
            txtbName.Clear();
            txtbAreacode.Clear();
            txtbAddress.Clear();
            txtbPhonenumber.Clear();
            txtbCVRNumber.Clear();
            txtbEmail.Clear();
        }
       
        private void ValidateInputAndApply(Func<String, int, String, int, int, String, int> func)
        {
            bool errorFound = false;
            int areacode = 0, phonenumber = 0, cvrnumber = 0;
            // tester om der er noget i text boxene
            if (Utilities.IsNotSetCorrect(txtbName.Text))
            {
                errorFound = true;
                txtbName.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            else
            {
                txtbName.ClearValue(TextBox.BorderBrushProperty);
            }

            if (Utilities.IsNotSetCorrect(txtbAreacode.Text))
            {
                errorFound = true;
                txtbAreacode.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            else
            {
                try
                {
                    areacode = int.Parse(txtbAreacode.Text);
                    txtbAreacode.ClearValue(TextBox.BorderBrushProperty);
                }
                catch
                {
                    errorFound = true;
                    txtbAreacode.BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }

            if (Utilities.IsNotSetCorrect(txtbAddress.Text))
            {
                errorFound = true;
                txtbAddress.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            else
            {
                txtbAddress.ClearValue(TextBox.BorderBrushProperty);
            }

            if (Utilities.IsNotSetCorrect(txtbPhonenumber.Text))
            {
                errorFound = true;
                txtbPhonenumber.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            else
            {
                try
                {
                    phonenumber = int.Parse(txtbPhonenumber.Text);
                    txtbPhonenumber.ClearValue(TextBox.BorderBrushProperty);
                }
                catch
                {
                    errorFound = true;
                    txtbPhonenumber.BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }

            if (Utilities.IsNotSetCorrect(txtbCVRNumber.Text))
            {
                errorFound = true;
                txtbCVRNumber.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            else
            {
                try
                {
                    cvrnumber = int.Parse(txtbCVRNumber.Text);
                    txtbCVRNumber.ClearValue(TextBox.BorderBrushProperty);
                }
                catch
                {
                    errorFound = true;
                    txtbCVRNumber.BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }

            if (Utilities.IsNotSetCorrect(txtbEmail.Text))
            {
                errorFound = true;
                txtbEmail.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            else
            {
                txtbEmail.ClearValue(TextBox.BorderBrushProperty);
            }
            // tester om der er tal i text boxene
            if (errorFound == false)
            {
                
                try
                {
                    phonenumber = int.Parse(txtbPhonenumber.Text);
                }
                catch
                {
                    errorFound = true;
                    txtbPhonenumber.BorderBrush = new SolidColorBrush(Colors.Red);
                }
                try
                {
                    cvrnumber = int.Parse(txtbCVRNumber.Text);
                }
                catch
                {
                    errorFound = true;
                    txtbCVRNumber.BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
            if(errorFound)
            {
                MessageBox.Show("Input Error");
                return;
            }
            // alle tests gennemført

            func(txtbName.Text, areacode, txtbAddress.Text, phonenumber, cvrnumber, txtbEmail.Text );
        }

        private int Create_Costumer(String name, int areaCode, String address, int phoneNumber, int cvrNumber, String email)
        {
            Costumer costumer = new Costumer();
                      
            costumer.Name = name;
                       
            costumer.AreaCode = areaCode;
                       
            costumer.Address = address;
                      
            costumer.PhoneNumber = phoneNumber;
                      
            costumer.CVRNumnber = cvrNumber;
                       
            costumer.Email = email;

            db.Costumer.Add(costumer);
            db.SaveChanges();
            Populate_lvCostumer(db, lvCostumers);
            ClearGUI();
            return 1;
        }

        private int Update_Costumer(String name, int areaCode, String address, int phoneNumber, int cvrNumber, String email)
        {
            Costumer costumer = (Costumer)lvCostumers.SelectedItem;

            
            costumer.Name = name;
           
            costumer.AreaCode = areaCode;
          
            costumer.Address = address;
            
            costumer.PhoneNumber = phoneNumber;
           
            costumer.CVRNumnber = cvrNumber;
           
            costumer.Email = email;

            db.SaveChanges();
            Populate_lvCostumer(db, lvCostumers);
            ClearGUI();
            return 1;
        }

        private void Delete_Costumer()
        {
            Costumer selected = (Costumer)lvCostumers.SelectedItem;
            db.Costumer.Remove(selected);
            db.SaveChanges();
            Populate_lvCostumer(db, lvCostumers);
            ClearGUI();
        }

        public MainWindow()
        {
            InitializeComponent();
            //ClearGUI();
            db = new TargetEntities();
            Populate_lvCostumer(db, lvCostumers);
        }

            //create_Costumer();
        private void Event_btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            ValidateInputAndApply(Create_Costumer);
        }

        //Update information in the boxes
        private void Event_btnUpdate_Click(object sender, RoutedEventArgs e)
        { 
            ValidateInputAndApply(Update_Costumer);
        }

        // Delete a costumer from the database
        private void Event_btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Delete_Costumer();
        }

        private void Event_tbName_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                //create_Costumer();
            }
        }

        private void LvCostumers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvCostumers.SelectedItems.Count!=1)
            {
                return;
            }
            Costumer selected = (Costumer)lvCostumers.SelectedItem;
            txtbName.Text = selected.Name;
            txtbAreacode.Text = selected.AreaCode.ToString();
            txtbAddress.Text = selected.Address;
            txtbPhonenumber.Text = selected.PhoneNumber.ToString();
            txtbCVRNumber.Text = selected.CVRNumnber.ToString();
            txtbEmail.Text = selected.Email; 

        }

        private void Event_btnProductList_Click(object sender, RoutedEventArgs e)
        {
            ProductWindow prod = new ProductWindow();            
            prod.Show();
            this.Hide();
        }

        private void Event_btnOrder_Click(object sender, RoutedEventArgs e)
        {
            OrdersWindow order = new OrdersWindow();
            order.Show();
            this.Hide();
        }

        private void Event_btnOrderLine_Click(object sender, RoutedEventArgs e)
        {
            OrderLineWindow orderLine = new OrderLineWindow();
            orderLine.Show();
            this.Hide();
        }

     
    }
}
