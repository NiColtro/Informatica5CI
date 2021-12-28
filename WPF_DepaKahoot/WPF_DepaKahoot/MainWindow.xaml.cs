using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace WPF_DepaKahoot
{
    public partial class MainWindow : Window
    {
        Question q;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartHandler(object sender, RoutedEventArgs e)
        {
            List<Card> cards = new List<Card>(); // Lista di domande per il quiz, vuoto

            XmlSerializer mySerializer = new XmlSerializer(typeof(List<Card>)); // XML
            FileStream fs = new FileStream(@"Z:\kahoot.xml", FileMode.Open); // Stream del file
            cards = (List<Card>) mySerializer.Deserialize(fs); // Lista di domande deserializzata da XML
            fs.Close(); // Chiude stream file

            string cats = "";
            foreach (CheckBox cb in Categories.Children) // Concatena in stringa
                if ((bool) cb.IsChecked)
                    cats += cb.Name + ";";

            cards.RemoveAll(card => !(cats.Contains(card.Category.ToString()))); // Per tutte le categorie non interessate

            q = new Question(Nickname.Text, cards); // Genera finestra gioco
            q.Show(); // Mostra
        }

        private void ExitHandler(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); // Chiude il gioco
        }
    }
}
