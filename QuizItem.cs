using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedWebArcitechture_ConsoleQuiz
{
    public class QuizItem
    {
        public string Question { get; set; }

        public List<string> Answers { get; set; } = new List<string>();

        public int CorrectAnswer { get; set; }
    }
}
