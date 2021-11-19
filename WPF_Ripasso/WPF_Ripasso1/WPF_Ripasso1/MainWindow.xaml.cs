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

namespace WPF_Ripasso1 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        Grid dynGrid;

        public MainWindow() {
            InitializeComponent();
        }

        private void GeneraGriglia_Click(object sender, RoutedEventArgs e) {

            if (dynGrid != null)
                MainGrid.Children.Remove(dynGrid);
            
            dynGrid = new Grid();
            dynGrid.ShowGridLines = true;

            int numRighe = int.Parse(NumeroRighe.Text);
            int numColonne = int.Parse(NumeroColonne.Text);

            for (int iterazioniRighe = 0; iterazioniRighe < numRighe; iterazioniRighe++) {
                dynGrid.RowDefinitions.Add(new RowDefinition());
            }

            for (int interazioniColonne = 0; interazioniColonne < numColonne; interazioniColonne++) {
                dynGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < numRighe; i++)
                for (int j = 0; j < numColonne; j++) {

                    Label l = new Label();
                    l.Content = "Questa è la cella " + i + ";" + j;
                    dynGrid.Children.Add(l);

                    Grid.SetRow(l, i);
                    Grid.SetColumn(l, j);
                }

            MainGrid.Children.Add(dynGrid);
            Grid.SetRow(dynGrid, 1);
            Grid.SetColumn(dynGrid, 0);
        }
    }
}
