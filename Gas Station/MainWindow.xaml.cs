using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gas_Station
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isON = false;
        int shopSum = 0;
        int total = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            int amount1 = 0;
            int amount2 = 0;
            int amoutn3 = 0;
            int litrAI80 = 100;
            int litrAI90 = 160;
            int litrDiesel = 180;
            if (textBox.Text != "")
            {

                int intValue = 0;
                if (!Int32.TryParse(textBox.Text, out intValue))
                {
                    MessageBox.Show("Вводите только цифры");
                    textBox.Text = "";
                    textBox_Copy.Text = "";
                    textBox_Copy1.Text = "";
                    return;
                }

                amount1 = intValue;
            }
            if (textBox_Copy.Text != "")
            {
                int intValue1 = 0;
                if (!Int32.TryParse(textBox_Copy.Text, out intValue1))
                {
                    MessageBox.Show("Вводите только цифры");
                    textBox_Copy.Text = "";
                    textBox_Copy.Text = "";
                    textBox_Copy1.Text = "";
                    return;
                }
                amount2 = intValue1;
            }
            if (textBox_Copy1.Text != "")
            {
                int intValue2 = 0;
                if (!Int32.TryParse(textBox_Copy1.Text, out intValue2))
                {
                    MessageBox.Show("Вводите только цифры");
                    textBox_Copy1.Text = "";
                    textBox_Copy.Text = "";
                    textBox_Copy1.Text = "";
                    return;
                }
                amoutn3 = intValue2;
            }

            if (checkBox.IsChecked == true)
            {
                shopSum += 120;
            }
            if (checkBox_Copy.IsChecked == true)
            {
                shopSum += 150;
            }
            if (checkBox_Copy1.IsChecked == true)
            {
                shopSum += 120;
            }
            if (checkBox_Copy3.IsChecked == true)
            {
                shopSum += 150;
            }
            if (checkBox_Copy4.IsChecked == true)
            {
                shopSum += 130;
            }
            if (checkBox_Copy5.IsChecked == true)
            {
                shopSum += 120;
            }
            if (checkBox_Copy7.IsChecked == true)
            {
                shopSum += 180;
            }
            if (checkBox_Copy8.IsChecked == true)
            {
                shopSum += 150;
            }
            if (checkBox_Copy9.IsChecked == true)
            {
                shopSum += 300;
            }


            total = amount1*litrAI80 + amount2*litrAI90 + amoutn3*litrDiesel+shopSum;

            Sum ss = (Sum)this.Resources["TotalSum"];
            ss.Summa += total;
            textBox.Text = "";
            textBox_Copy.Text = "";
            textBox_Copy1.Text = "";
            checkBox_Copy.IsChecked = false;
            checkBox_Copy1.IsChecked = false;
            checkBox_Copy3.IsChecked = false;
            checkBox_Copy4.IsChecked = false;
            checkBox_Copy5.IsChecked = false;
            checkBox_Copy.IsChecked = false;
            checkBox_Copy7.IsChecked = false;
            checkBox_Copy8.IsChecked = false;
            checkBox_Copy9.IsChecked = false;
            checkBox.IsChecked = false;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Sum s = (Sum)this.Resources["TotalSum"];
            s.Summa = 0;
            total = 0;
            shopSum = 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (isON == false)
            {
                space.Visibility = Visibility.Visible;
                shogun.Margin = new Thickness(0, 0, 0, 0);
                this.Height += 90;
                
            }
            else
            {
                space.Visibility = Visibility.Hidden;
                shogun.Margin = new Thickness(0, -150, 0, 0);
                this.Height -= 90;
            }
            isON = !isON;
            
           
        }
    }
}
