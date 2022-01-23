using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPF_DepaKahoot
{
    public enum Category
    {
        CulturaGenerale,
        Musica, 
        Cinema
    }

    public class Answer
    {
        public string Text { get; set; }
        public bool Correct { get; set; }

        public Answer(string text, bool correct)
        {
            Text = text;
            Correct = correct;
        }

        public Answer() { }
    }

    public class Card
    {
        public string Question { get; set; }
        public Category Category { get; set; }
        public List<Answer> Answers { get; set; }

        public Card(string question, Category category, List<Answer> answers)
        {
            Question = question;
            Category = category;
            Answers = answers;
        }

        public Card() { }
    }
}
