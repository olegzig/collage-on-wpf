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
    /// Логика взаимодействия для Энергосбережение.xaml
    /// </summary>
    public partial class Энергосбережение : Window
    {
        public Энергосбережение()
        {
            InitializeComponent();

            this.Closed += this_Closed;
        }
        private void this_Closed(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}
