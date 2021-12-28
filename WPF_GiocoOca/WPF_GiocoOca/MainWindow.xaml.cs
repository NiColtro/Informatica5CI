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

namespace WPF_GiocoOca
{
    
    public class Player
    {
        public string Nome { get; set; }
        public Brush Colore { get; set; }
        public int Posizione { get; set; }

        public Player(string nome, Brush colore)
        {
            Nome = nome;
            Colore = colore;
            Posizione = 0;
        }
    }

    public partial class MainWindow : Window
    {
        List<Player> players = new List<Player>();

        public MainWindow()
        {
            InitializeComponent();

            
            Dadi dd = new Dadi();
            dd.Show();

            players.Add(new Player("P1", Brushes.Red));
            players.Add(new Player("P2", Brushes.Blue));

            Tabellone tb = new Tabellone(players);
            tb.Show();
        }

        private void PlayButtonHandler(object sender, RoutedEventArgs e)
        {
            
        }

        private void ExitButtonHandler(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
