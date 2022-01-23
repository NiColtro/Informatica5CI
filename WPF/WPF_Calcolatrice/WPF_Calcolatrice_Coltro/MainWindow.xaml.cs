using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPF_Calcolatrice
{
    public partial class MainWindow : Window
    {
        private string buffer = "";
        private bool ris = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        public static string eval(string s)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("expression", typeof(string), s);
                DataRow dr = dt.NewRow();
                dt.Rows.Add(dr);
                return (string)dr["expression"];
            }
            catch
            {
                return "Err";
            }
        }

        public string key2Char(Key k)
        {
            switch (k)
            {
                case Key.Add:
                    return "+";
                case Key.Subtract:
                    return "-";
                case Key.Multiply:
                    return "*";
                case Key.Divide:
                    return "/";
                case Key.Escape:
                    return "C";
                case Key.Return:
                    return "=";
                case Key.Back:
                    return "B";
                default:
                    string ks = k.ToString();

                    if (ks[ks.Length - 1] >= 48 && ks[ks.Length - 1] <= 57)
                        return ks[ks.Length - 1].ToString(); // Numbers
                    else
                        return ""; // Other Keys
            }
        }

        private void ButtonHandler(object s, RoutedEventArgs e)
        {
            uguale.Focus();
            send2Display((s as Button).Content.ToString()); // Check pressed button
        }

        private void KeyboardHandler(object s, KeyEventArgs e)
        {
            uguale.Focus();
            send2Display(key2Char(e.Key)); // Check pressed key (toChar)
        }

        private void send2Display(string s)
        {
            if (s == "C" || ris)
            {
                ris = false; // Reset result flag
                buffer = ""; // Empty buffer
            }

            if (s == "=")
            {
                buffer = eval(buffer).ToString(); // Calc expression
                ris = true; // Enable result flag
            }
            else if (s == "B" && buffer.Length > 0)
                buffer = buffer.Substring(0, buffer.Length - 1); // Remove last char
            else if (s != "C" && s != "B")
                buffer += s; // Stack in buffer

            display.Content = buffer; // Send buffer to display (label)
        }
    }
}
