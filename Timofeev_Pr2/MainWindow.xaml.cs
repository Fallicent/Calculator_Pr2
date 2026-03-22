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
using Timofeev_lib;

namespace Timofeev_Pr2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Answer(object sender, RoutedEventArgs e)
        {
            output.Text = Calc.Go(input.Text);
        }


        private void Br_o(object sender, RoutedEventArgs e)
        {
            input.Text += "(";
        }
        private void Br_c(object sender, RoutedEventArgs e)
        {
            input.Text += ")";
        }
        private void Minus(object sender, RoutedEventArgs e)
        {
            input.Text += "-";
        }
        private void Plus(object sender, RoutedEventArgs e)
        {
            input.Text += "+";
        }
        private void Divide(object sender, RoutedEventArgs e)
        {
            input.Text += "/";
        }
        private void Multiply(object sender, RoutedEventArgs e)
        {
            input.Text += "*";
        }
        private void Pow_up(object sender, RoutedEventArgs e)
        {
            input.Text += "^";
        }
        private void Erase(object sender, RoutedEventArgs e)
        {
            input.Text = "";
        }
        private void Point(object sender, RoutedEventArgs e)
        {
            input.Text += ",";
        }
        public void One(object sender, RoutedEventArgs e)
        {
            input.Text += "1";
        }

        private void Two(object sender, RoutedEventArgs e)
        {
            input.Text += "2";
        }

        private void Three(object sender, RoutedEventArgs e)
        {
            input.Text += "3";
        }

        private void Four(object sender, RoutedEventArgs e)
        {
            input.Text += "4";
        }

        private void Five(object sender, RoutedEventArgs e)
        {
            input.Text += "5";
        }
        private void Six(object sender, RoutedEventArgs e)
        {
            input.Text += "6";
        }
        private void Seven(object sender, RoutedEventArgs e)
        {
            input.Text += "7";
        }
        private void Eight(object sender, RoutedEventArgs e)
        {
            input.Text += "8";
        }
        private void Nine(object sender, RoutedEventArgs e)
        {
            input.Text += "9";
        }
        private void Zero(object sender, RoutedEventArgs e)
        {
            input.Text += "0";
        }

    }
}
