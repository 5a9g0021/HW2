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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxButton button = MessageBoxButton.OK;
            Double zero = 0;




            int n;
            bool isNum = int.TryParse(textbox01.Text, out n);







            if (isNum && n >= 2)
            {
                float num = (float)Convert.ToSingle(textbox01.Text);
                string displayMessage = "";
                for (int i = 2; i <= num; i++)
                {
                    for (int k = 2; k <= i; k++)
                    {
                        if (i % k == 0 && i != k)
                        {
                            break;
                        }
                        if (i % k == 0 && i == k)
                        {

                            displayMessage += $" {i}";

                            if (i % k == 0 && i == k)
                            {

                                textbox03.Text += $"{i}的倍數: ";

                                for (int j = i; j <= num; j = j + i)
                                {
                                    textbox03.Text += ($"{j} ");
                                }
                                textbox03.Text += $"\n";
                            }




                        }
                    }
                }

                MessageBox.Show($"所輸入數字為:{num}", "求質數", button);
                textbox02.Text = $"小於等於{num}的質數{displayMessage}\n ";

            }
            else if (isNum && n < 2)
            {
                MessageBox.Show("請輸入正整數");
            }
            else
            {
                MessageBox.Show("請輸入整數");
            }
        }
    }
}

