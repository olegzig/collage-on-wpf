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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Солнечные_панели.xaml
    /// </summary>
    public partial class Солнечные_панели : Window
    {
        public Солнечные_панели()
        {
            InitializeComponent();

            this.Closed += this_Closed;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Owner.Show();
            this.Close();
        }
        private void this_Closed(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}
