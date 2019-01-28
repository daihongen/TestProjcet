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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        int firstnum = 0;
        int secondnum = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (sender.ToString()) {
                case "System.Windows.Controls.Button: 1":
                    Console.WriteLine("Sender" + sender);
                    text.Text += "1";
                    break;
                case "System.Windows.Controls.Button: 2":
                    text.Text += "2";
                    break;
                case "System.Windows.Controls.Button: 3":
                    text.Text += "3";
                    break;
                case "System.Windows.Controls.Button: 4":
                    text.Text += "4";
                    break;
                case "System.Windows.Controls.Button: 5":
                    text.Text += "5";
                    break;
                case "System.Windows.Controls.Button: 6":
                    text.Text += "6";
                    break;
                case "System.Windows.Controls.Button: 7":
                    text.Text += "7";
                    break;
                case "System.Windows.Controls.Button: 8":
                    text.Text += "8";
                    break;
                case "System.Windows.Controls.Button: 9":
                    text.Text += "9";
                    break;
                case "System.Windows.Controls.Button: 0":
                    text.Text += "0";
                    break;
                case "System.Windows.Controls.Button: C":
                    text.Text = "";
                    break;
            }
        }

        private void Button_Click_Operatin(object sender, RoutedEventArgs e)
        {
            switch (sender.ToString()) {
                case "System.Windows.Controls.Button: +":
                    
                    break;
                case "System.Windows.Controls.Button: -":

                    break;
                case "System.Windows.Controls.Button: *":

                    break;
                case "System.Windows.Controls.Button: /":

                    break;
            }
        }
    }
}
