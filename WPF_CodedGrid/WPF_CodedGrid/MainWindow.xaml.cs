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

namespace WPF_CodedGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Grid lastGrid;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonHandler(object sender, RoutedEventArgs e)
        {
            Grid g = new Grid(); // New grid
            g.ShowGridLines = true;

            int colCount = int.Parse(colNum.Text.ToString());
            int rowCount = int.Parse(rowNum.Text.ToString());

            for (int i = 0; i < colCount; i++)
                g.ColumnDefinitions.Add(new ColumnDefinition());

            for (int i = 0; i < rowCount; i++)
                g.RowDefinitions.Add(new RowDefinition());

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    Label l = new Label();
                    l.Content = "Cella " + j + ";" + i;
                    g.Children.Add(l);

                    Grid.SetRow(l, i);
                    Grid.SetColumn(l, j);
                }
            }

            if (lastGrid != null) // If lastGrid exists, remove
                mainGrid.Children.Remove(lastGrid);

            mainGrid.Children.Add(g); // Append to main grid
            lastGrid = g; // Update last grid

            Grid.SetRow(g, 1); // Set new grid position in main grid
        }
    }
}
