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

namespace _23_107k_Denisov_1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string input = InputNumber.Text;

                if (input.Length != 12 || !long.TryParse(input, out _))
                {
                    ResultTextBlock.Text = "Введите корректное двенадцатизначное число.";
                    return;
                }

                int firstThreeProduct = (input[0] - '0') * (input[1] - '0') * (input[2] - '0');

                int lastNineSum = 0;

                for (int i = 3; i < 12; i++)
                {
                    lastNineSum += input[i] - '0';
                }

                if (firstThreeProduct == lastNineSum)
                {
                    ResultTextBlock.Text = "Произведение первых трех цифр равно сумме последних девяти.";
                }
                else
                {
                    ResultTextBlock.Text = "Произведение первых трех цифр не равно сумме последних девяти.";
                }
            }
            catch (Exception ex)
            {
                ResultTextBlock.Text = $"Произошла ошибка: {ex.Message}";
            }
        }

    }

}
