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

namespace WPF_GiocoOca
{
    /// <summary>
    /// Logica di interazione per Dadi.xaml
    /// </summary>
    public partial class Dadi : Window
    {
        public Dadi()
        {
            InitializeComponent();
        }

        private void RollButtonHandler(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            int d1 = r.Next(1, 7);
            int d2 = r.Next(1, 7);

            Dado1.Content = d1;
            Dado2.Content = d2;
        }
    }
}
