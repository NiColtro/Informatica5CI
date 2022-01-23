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

namespace WPF_Controls {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
 
            Info.Text = "Questo è un testo moooooooooooooolto lungo. Forse non abbastanza... Boh.";
        }

        private void Salva_Click(object sender, RoutedEventArgs e) {
            string password = iPassword.Password;
            string sesso = "Uomo";

            if (ibUomo.IsChecked == true)
                sesso = ibUomo.Content.ToString();
            else if (ibDonna.IsChecked == true)
                sesso = ibDonna.Content.ToString();

            string dataNascita = "";
            if (iDataNascitaCal.SelectedDate != null) {
                DateTime dd = iDataNascitaCal.SelectedDate.Value;
                dataNascita = dd.ToString("dd/MM/yyyy");
            }

            MessageBox.Show(dataNascita);
        }

        private void Carica_Click(object sender, RoutedEventArgs e) {

        }

        private void Esci_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        }

        private void iDataNascitaCal_SelectedDatesChanged(object sender, SelectionChangedEventArgs e) {
            DateTime dd = iDataNascitaCal.SelectedDate.Value;
            iDataNascita.Text = dd.ToString("dd/MM/yyyy");
        }
    }
}
