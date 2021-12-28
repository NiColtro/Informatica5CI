using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace WPF_GiocoOca
{
    public partial class Tabellone : Window
    {
        List<Player> players = new List<Player>();
        static int x = 5;
        static int y = 5;

        public void GridRender()
        {
            for (int i = 0; i < x; i++)
                GrigliaTabellone.RowDefinitions.Add(new RowDefinition());

            for (int i = 0; i < y; i++)
                GrigliaTabellone.ColumnDefinitions.Add(new ColumnDefinition());

            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    Label l = new Label();
                    l.Content = "Cella" + i + ";" + j;

                    GrigliaTabellone.Children.Add(l);
                    Grid.SetRow(l, i);
                    Grid.SetColumn(l, j);
                }
        }

        public Tabellone(List<Player> players)
        {
            InitializeComponent();

            this.players = players;

            players.ForEach(p =>
            {
                Ellipse e = new Ellipse();
                e.Fill = p.Colore;
                e.Width = 10;
                e.Height = 10;

                /*if (players.FindAll(cp => cp.Posizione == p.Posizione).Count > 0)
                    e.Margin.Top = Thickness.;*/

                GrigliaTabellone.Children.Add(e);
                Grid.SetRow(e, 0);
                Grid.SetColumn(e, 0);
            });
        }
    }
}
