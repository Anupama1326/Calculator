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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long num1 = 0;
        long num2 = 0;
        string operation = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 1;
                txtresult.Text = num1.ToString();
            }
            else
            {
                num2 = num2 * 10 + 1;
                txtresult.Text = num2.ToString();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 2;
                txtresult.Text = num1.ToString();
            }
            else
            {
                num2 = num2 * 10 + 2;
                txtresult.Text = num2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 3;
                txtresult.Text = num1.ToString();
            }
            else
            {
                num2 = num2 * 10 + 3;
                txtresult.Text = num2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 4;
                txtresult.Text = num1.ToString();
            }
            else
            {
                num2 = num2 * 10 + 4;
                txtresult.Text = num2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 5;
                txtresult.Text = num1.ToString();
            }
            else
            {
                num2 = num2 * 10 + 5;
                txtresult.Text = num2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 6;
                txtresult.Text = num1.ToString();
            }
            else
            {
                num2 = num2 * 10 + 6;
                txtresult.Text = num2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 7;
                txtresult.Text = num1.ToString();
            }
            else
            {
                num2 = num2 * 10 + 7;
                txtresult.Text = num2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 8;
                txtresult.Text = num1.ToString();
            }
            else
            {
                num2 = num2 * 10 + 8;
                txtresult.Text = num2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 9;
                txtresult.Text = num1.ToString();
            }
            else
            {
                num2 = num2 * 10 + 9;
                txtresult.Text = num2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = num1*10;
                txtresult.Text = num1.ToString();
            }
            else
            {
                num2 = num2 * 10;
                txtresult.Text = num2.ToString();
            }
        }

        private void btnce_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = num1 * 10;
                txtresult.Text = num1.ToString();
            }
            else
            {
                num2 = 0;
                txtresult.Text = num2.ToString();
            }
        }

        private void btnc_Click(object sender, RoutedEventArgs e)
        {
            //if (operation == "")
            //{
            //    num1 = num1 / 10;
            //    txtresult.Text = num1.ToString();
            //}
            //else
            //{
            //    num2 = num2 / 10;
            //    txtresult.Text = num2.ToString();
            //}
            if (operation == "")
            {
                num1 = 0;
                txtresult.Text = num1.ToString();
            }
            else
            {
                num2 = 0;
                txtresult.Text = num2.ToString();
            }
        }

        private void btnbackspace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = num1 / 10;
                txtresult.Text = num1.ToString();
            }
            else
            {
                num2 = num2 / 10;
                txtresult.Text = num2.ToString();
            }
        }
        private void btnplus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtresult.Text = "0";
        }

        private void btnminus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtresult.Text = "0";
        }

        private void btninto_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txtresult.Text = "0";
        }

        private void btnby_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtresult.Text = "0";
        }

        private void btneql_Click(object sender, RoutedEventArgs e)
        {
            switch(operation)
            {
                case "+":
                    txtresult.Text = (num1+num2).ToString();                  
                    break;
                case "-":
                    txtresult.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    txtresult.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    txtresult.Text = (num1 / num2).ToString();
                    break;
            }

        }

        private void btnplusminus_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                num1 *= -1;
                txtresult.Text = num1.ToString();
            }
            else
            {
                num2 *= -1;
                txtresult.Text = num2.ToString();
            }
        }
    }
}
