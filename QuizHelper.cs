using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedWebArcitechture_ConsoleQuiz
{
    public static class QuizHelper
    {
        public static List<QuizItem> GetAllQuizItems()
        {
            var quizItemsList = new List<QuizItem>(){
                new QuizItem()
                {
                    Question = "What is the rarest M&M color?",
                    Answers = new List<string>{"blue", "brown", "purple"},
                    CorrectAnswer = 2
                },
                new QuizItem()
                {
                    Question = "In a website browser address bar, what does “www” stand for?",
                    Answers = new List<string>{"world wide web", "who what where", "we want walruses"},
                    CorrectAnswer = 1
                },
                new QuizItem()
                {
                    Question = "In what year were the first Air Jordan sneakers released?",
                    Answers = new List<string>{"1994", "1984", "1974"},
                    CorrectAnswer = 2
                },
                new QuizItem()
                {
                    Question = "According to Greek mythology, who was the first woman on earth?",
                    Answers = new List<string>{"Athena", "Eve", "Pandora"},
                    CorrectAnswer = 3
                },
                new QuizItem()
                {
                    Question = "Istanbul used to be called?",
                    Answers = new List<string>{"Constantinople", "Byzantine", "Ankara"},
                    CorrectAnswer = 1
                },
                new QuizItem()
                {
                    Question = "In which European city would you find Orly airport?",
                    Answers = new List<string>{"Rome", "Paris", "Munich"},
                    CorrectAnswer = 2
                },
                new QuizItem()
                {
                    Question = "Which singer’s real name is Stefani Joanne Angelina Germanotta?",
                    Answers = new List<string>{"Lady Gaga", "Katy Perry", "Rihanna"},
                    CorrectAnswer = 1
                },
                new QuizItem()
                {
                    Question = "Which Dutch artist painted “Girl with a Pearl Earring?",
                    Answers = new List<string>{"Vermeer", "Van Gogh", "Mondrian"},
                    CorrectAnswer = 1
                },
                new QuizItem()
                {
                    Question = "Which country consumes the most chocolate per capita?",
                    Answers = new List<string>{"Sweden", "Switzerland", "Netherlands"},
                    CorrectAnswer = 2
                },
                new QuizItem()
                {
                    Question = "What is the tiny piece at the end of a shoelace called?",
                    Answers = new List<string>{"an angel", "an aglet", "an amulet"},
                    CorrectAnswer = 2
                }
            };

            return quizItemsList;
        }
    }
}
