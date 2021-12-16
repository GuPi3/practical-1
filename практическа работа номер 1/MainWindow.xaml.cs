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
using Lib_8;

namespace практическа_работа_номер_1
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


        private void ResultOutput(object sender, RoutedEventArgs e)
        {
            arrayOutput.Clear();
            bool f = Int32.TryParse(inputBox.Text, out int tryParseResult);
            try
            {
                ProgramModules.SumEvenWithOut(Convert.ToInt32(inputBox.Text), out int max, out string numbers);
                for (int i = 0; i < numbers.Length; i++)
                {
                    arrayOutput.Text += numbers[i].ToString() + " ";

                }
                maximalNumber.Text = max.ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }

        }

        private void Exit_Button(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Info_Button(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил работу Селиванов Егор ИСП-31 Найти максимум из n целых случайных чисел X, распределенных в диапазоне от 0 до n.Вывести на экран на одной строке сгенерированные числа, на другой строкерезультат.");
        }
    }
}
