using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WPF_FlappyBird {
    public partial class MainWindow : Window {
        Random rand; // Random generator
        DispatcherTimer birdTick; // Bird tick
        DispatcherTimer obstacleTick; // Obstacle tick

        bool gravity = true; // Bird gravity
        int skip; // Skip obstacle generator

        public MainWindow() {
            InitializeComponent();

            // Init vars
            birdTick = new DispatcherTimer();
            obstacleTick = new DispatcherTimer();
            rand = new Random();
            skip = 0;
            
            // BirdTick
            birdTick.Interval = TimeSpan.FromMilliseconds(10);
            birdTick.Tick += BirdTickHandler;
            birdTick.Start();

            // ObstacleTick
            obstacleTick.Interval = TimeSpan.FromMilliseconds(5);
            obstacleTick.Tick += ObstacleTickHandler;
            obstacleTick.Start();
        }

        private bool BirdTouching() { // Check if Bird is touching an obstacle
            foreach (var c in PlayArea.Children) // For every obstacle
                if (c is Rectangle) { // Check if children is a Rectangle (obstacle)
                    Rectangle r = (Rectangle) c;

                    if (Canvas.GetLeft(Bird) + Bird.ActualWidth >= Canvas.GetLeft(r) && Canvas.GetLeft(Bird) <= Canvas.GetLeft(r) + r.ActualWidth) // Check X
                        if ((Canvas.GetTop(Bird) <= Canvas.GetTop(r) + r.ActualHeight && r.Tag.ToString() == "top") || (Canvas.GetTop(Bird) + Bird.ActualHeight >= Canvas.GetTop(r) && r.Tag.ToString() == "bottom")) // Check Y
                            return true;
                }

            return false;             
        }

        private void DeathCheck() { // Check if game is lost
            if (BirdTouching()) {
                Bird.Fill = Brushes.Yellow; // Set Bird to yellow
                birdTick.Stop();
                obstacleTick.Stop();
            }
        }

        private void ShiftObstacles(double dif) { // Shift all obstacles of X
            foreach (var c in PlayArea.Children) // For every child
                if (c is Rectangle)
                { // If is a Rectangle (obstacle)
                    Rectangle r = (Rectangle)c;

                    if (Canvas.GetLeft(r) < 0)
                    { // Remove shape if outside of the screen (left margin)
                        PlayArea.Children.RemoveRange(1, 1); // Remove first two childens, skip Bird [Bird, (Obstacle), (Obstacle), Obstacle...]
                        break; // Cannot cycle in modified list! Need to break
                    }
                    else // Shift shape to left
                        Canvas.SetLeft(r, Canvas.GetLeft(r) + dif);
                }
        }

        private void ObstacleTickHandler(object sender, EventArgs e) {
            DeathCheck(); // Check game status
            ShiftObstacles(-2); // Shift rectangles

            if (skip == 80) { // If 80 ticks have occurred...
                obstacleGenerator(PlayArea.ActualHeight - Bird.ActualHeight - 50).ForEach(r => { // Generate new pair of obstacles (with max)
                    PlayArea.Children.Add(r);

                    if (r.Tag.ToString() == "bottom") // If it sticks to bottom...
                        Canvas.SetTop(r, PlayArea.ActualHeight - r.Height); // Y Position is (bottom margin - obstacle height)
                    else // Or top...
                        Canvas.SetTop(r, 0); // Y Position is (absolute top)

                    Canvas.SetLeft(r, PlayArea.ActualWidth); // X position is (absolute right)
                });

                skip = 0; // Reset tick counter
            }

            skip++; // Increment tick counter
        }

        private List<Rectangle> obstacleGenerator(double maxHeight) { // Generate pair of obstacles
            List<Rectangle> pair = new List<Rectangle>();
            int h1, h2; // Height 1,2
            int w = rand.Next(15, 40); // Random Rectangle width

            do {
                h1 = rand.Next(150, 200);
                h2 = rand.Next(100, 200);
            } while ((h1 + h2) >= maxHeight); // While height is not acceptable

            if (rand.Next(2) == 1) { // Randomly invert shapes
                int aux = h1;
                h1 = h2;
                h2 = aux;
            }

            Rectangle r = new Rectangle(); // Generate top Rectangle
            r.Width = w;
            r.Height = h1;
            r.Fill = Brushes.Red;
            r.Tag = "top";
            pair.Add(r); // Add to pair list

            r = new Rectangle(); // Generate bottom Rectangle
            r.Width = w;
            r.Height = h2;
            r.Fill = Brushes.Tomato;
            r.Tag = "bottom";
            pair.Add(r); // Add to pair list

            return pair;
        }

        private void BirdTickHandler(object sender, EventArgs e) {
            if (gravity && Canvas.GetTop(Bird) + Bird.ActualHeight < PlayArea.ActualHeight) // If gravity is enabled and bird is not outside of bottom margin...
                BirdY(3.1); // Fall of DY
            else if (!gravity && Canvas.GetTop(Bird) > 0) // If gravity is disabled...
                BirdY(-3.5); // Levitate of DY
        }

        private void BirdY(double dif) { // Move Bird on Y axis
            Canvas.SetTop(Bird, Canvas.GetTop(Bird) + dif); // Set difference DY
        }

        private void GameReset() {
            Bird.Fill = Brushes.Green;
            birdTick.Start();
            obstacleTick.Start();

            Canvas.SetTop(Bird, PlayArea.ActualHeight / 2);
        }

        private void KeydownHandler(object sender, KeyEventArgs e) { // Handles KeyDown event
            if (e.Key == Key.Up) // While pressing up arrow key, gravity is disabled
                gravity = false;
            else if (e.Key == Key.R) // Reset Bird [TEST ONLY!]
                GameReset();
        }

        private void KeyupHandler(object sender, KeyEventArgs e) { // Handles KeyUp event
            if (e.Key == Key.Up) // Enable gravity on key release
                gravity = true;
        }
    }
}
