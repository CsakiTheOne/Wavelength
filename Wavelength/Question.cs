using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wavelength
{
    class Question
    {
        public string Text { get; private set; }
        public string[] Answers { get; private set; } = new string[] { "Igen", "Nem" };

        public Question(string text)
        {
            Text = text;
        }
        public Question(string text, string[] answers)
        {
            Text = text;
            Answers = answers;
        }

        public override string ToString()
        {
            string questionText = $"{Text}\n\r\n\r";

            for (int i = 0; i < Answers.Length; i++)
                questionText += $"{i + 1}. {Answers[i]}\n\r";

            return questionText;
        }
    }
}
