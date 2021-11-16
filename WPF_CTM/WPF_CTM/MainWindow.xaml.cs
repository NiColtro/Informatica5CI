using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace WPF_CTM {
    public partial class MainWindow : Window {
        DispatcherTimer timer; // Timer
        Random r = new Random(); // Random obj generator
        int clicks = 0; // Clicks counter

        Button lastButton; // Last clicked button
        List<Button> validClicks = new List<Button>(); // Valid clicks button list

        private void timerSetup() {
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timerHandler); // Execute at every timer tick
            timer.Interval = TimeSpan.FromMilliseconds(500); // Start interval between ticks
            timer.Start(); // Start timer
        }

        private void timerHandler(object sender, EventArgs e) {
            if (lastButton != null && !validClicks.Contains(lastButton)) // Check if lastButton exists and is not a valid one
                lastButton.Background = Brushes.White;

            int randomIndex = -1;

            do randomIndex = r.Next(9); // Generate a random index...
            while (validClicks.Contains(gameGrid.Children[randomIndex] as Button)); // ...while not already picked

            (gameGrid.Children[randomIndex] as Button).Background = Brushes.SandyBrown; // Identify current button
            lastButton = (Button)gameGrid.Children[randomIndex]; // Update lastButton
        }

        public void updateTimer(double millis) {
            timer.Interval = TimeSpan.FromMilliseconds(millis);
        }

        public MainWindow() {
            InitializeComponent();

            for (int i = 0; i < 3; i++) // Generate buttons
                for (int j = 0; j < 3; j++) {
                    Button b = new Button();
                    b.Click += ButtonHandler;
                    b.Background = Brushes.White;

                    gameGrid.Children.Add(b);
                    Grid.SetRow(b, i);
                    Grid.SetColumn(b, j);
                }

            timerSetup();
        }

        private void ButtonHandler(object sender, RoutedEventArgs e) {
            Button s = (Button)sender;

            mainGrid.Focus(); // Remove focus from selected button
            clicks += 1; // Count a click
            Clicks.Content = "Clicks: " + clicks;

            if (s == lastButton) { // Clicked button was the correct one
                updateTimer(timer.Interval.TotalMilliseconds * 0.95); // Decrese change interval
                validClicks.Add(s); // Add current button to valid list
                s.Background = (Brush) new BrushConverter().ConvertFrom("#faee70");

                Points.Content = "Punti: " + validClicks.Count;
            }

            if (validClicks.Count >= 9) { // WIN!
                timer.Stop();
                WinMsg.Visibility = Visibility.Visible;
            }
        }
    }
}
