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
using System.Windows.Shapes;

namespace WPF_DepaKahoot
{
    public partial class Question : Window
    {
        List<Card> cards;
        int index = -1;

        public Question(string nickname, List<Card> cards)
        {
            this.cards = cards;
            InitializeComponent();

            nextQuestion();
        }

        private void nextQuestion()
        {
            index++; // Avanza nell'array

            if (index >= cards.Count) // Controllo fine quiz
            {
                MessageBox.Show("Fine del quiz");
                Application.Current.Shutdown();
            }
            else
                MessageBox.Show("Prossima domanda");

            Card current = cards[index]; // Nuova domanda

            QuestionText.Content = current.Question; // Titolo domanda

            AnswersButtons.Children.Clear();

            current.Answers.ForEach(answer => { // Per ogni possibile risposta, genera il relativo bottone
                Button b = new Button();
                b.Content = answer.Text;
                b.Click += AnswerClick;

                AnswersButtons.Children.Add(b); // Here it goes
            }); 
        }

        private void AnswerClick(object sender, RoutedEventArgs e) // Controllo ad invio risposta
        {
            Button b = (Button)sender; // Risposta cliccata
            Answer a = cards[index].Answers.Find(answer => answer.Text == b.Content); // Risposta corrispondente (il bottone non si "porta dietro" l'oggetto)

            if (a.Correct) // Controllo risposta
                MessageBox.Show("Giusta!");
            else
                MessageBox.Show("Sbagliata!");

            nextQuestion();
        }
    }
}
