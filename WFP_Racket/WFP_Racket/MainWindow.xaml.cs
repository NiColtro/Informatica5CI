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
using System.Windows.Threading;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WFP_Racket {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        DispatcherTimer ballTimer = new DispatcherTimer();
        DispatcherTimer racketTimer = new DispatcherTimer();

        int incTop = 5, incLeft = 5;
        int racketMovement = 10;

        public MainWindow() {
            ballTimer.Interval = TimeSpan.FromMilliseconds(20);
            ballTimer.Tick += ballTimer_Tick;
            ballTimer.Start();

            racketTimer.Interval = TimeSpan.FromMilliseconds(20);
            racketTimer.Tick += racketTimer_Tick;

            InitializeComponent();
        }

        private void ballTimer_Tick(object sender, EventArgs e) { // Per ogni Tick della palla
            if (Canvas.GetLeft(Ball) + Ball.ActualWidth >= PlayArea.ActualWidth || Canvas.GetLeft(Ball) <= 0) // Margini sinistro e destro
                incLeft *= -1;

            if (Canvas.GetTop(Ball) + Ball.ActualHeight >= PlayArea.ActualHeight || Canvas.GetTop(Ball) <= 0) // Margini sopra e sotto
                incTop *= -1;

            if (Canvas.GetTop(Ball) + Ball.ActualHeight >= PlayArea.ActualHeight - Canvas.GetBottom(Racket) - Racket.ActualHeight /*&& */) // Tocca racchetta
                incTop *= -1;

            Canvas.SetLeft(Ball, Canvas.GetLeft(Ball) + incLeft);
            Canvas.SetTop(Ball, Canvas.GetTop(Ball) + incTop);
        }

        private void racketTimer_Tick(object sender, EventArgs e) { // Per ogni Tick della racchetta
            Canvas.SetLeft(Racket, Canvas.GetLeft(Racket) + racketMovement);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e) { // Tastiera Press
            if (e.Key == Key.Left)
                racketMovement = Math.Abs(racketMovement) * -1;
            else if (e.Key == Key.Right)
                racketMovement = Math.Abs(racketMovement);

            racketTimer.Start();
        }

        private void Window_KeyUp(object sender, KeyEventArgs e) { // Tastiera Unpress
            if (e.Key == Key.Left || e.Key == Key.Right)
                racketTimer.Stop();
        }
    }
}
