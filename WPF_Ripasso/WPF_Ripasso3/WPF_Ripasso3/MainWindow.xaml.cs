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
using System.Windows.Threading;

namespace WPF_Ripasso3 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        DispatcherTimer timer = new DispatcherTimer();

        public void onTimerTick(object sender, EventArgs e) {
            Orologio.Content = DateTime.Now.ToString("H:mm:ss");
        }

        public MainWindow() {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(onTimerTick);
            timer.Start();
        }
    }
}
