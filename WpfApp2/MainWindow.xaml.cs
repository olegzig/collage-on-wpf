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

namespace WpfApp2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Лампочки taskWindow = new Лампочки();
            taskWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Свет taskWindow = new Свет();
            taskWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Накипь taskWindow = new Накипь();
            taskWindow.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Холодильник taskWindow = new Холодильник();
            taskWindow.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Стены taskWindow = new Стены();
            taskWindow.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Пыль taskWindow = new Пыль();
            taskWindow.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Счётчики taskWindow = new Счётчики();
            taskWindow.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Окна taskWindow = new Окна();
            taskWindow.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Энергосбережение taskWindow = new Энергосбережение();
            taskWindow.Show();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Солнечные_панели taskWindow = new Солнечные_панели();
            taskWindow.Show();
        }
    }
}
