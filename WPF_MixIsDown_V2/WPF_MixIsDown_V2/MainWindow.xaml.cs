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
using Microsoft.Win32;

namespace WPF_MixIsDown_V2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BitmapImage tmpFoto;

        public MainWindow() {
            InitializeComponent();
        }

        private void PB_CaricaImg_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selezionare foto...";
            ofd.Filter = "File immagine (*.png)|*.png | Tutti i file (*.*)|*.*";
            ofd.InitialDirectory = @"C:\";

            bool? status = ofd.ShowDialog();

            if (status == null)
                MessageBox.Show("Errore");
            else if (status == true)
            {
                tmpFoto = new BitmapImage(new Uri(ofd.FileName, UriKind.Absolute));
                IMG_Foto.Source = tmpFoto;
            }

            
        }

        private void PB_SelVoce_Click(object sender, RoutedEventArgs e) {

        }

        private void PB_Aggiungi_Click(object sender, RoutedEventArgs e) {
            Persona p = new Persona();
            p.Cognome = TB_Cognome.Text;
            p.Nome = TB_Nome.Text;
            p.Foto = tmpFoto;

            LV_Persona.Items.Add(p);
        }

        private void LV_Persona_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            ListView lv = (ListView)sender;
            Persona p = new Persona((Persona)lv.SelectedItem); // Duplico oggetto, non è necessario

            TB_Cognome.Text = p.Cognome;
            TB_Nome.Text = p.Nome;
            IMG_Foto.Source = p.Foto;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
