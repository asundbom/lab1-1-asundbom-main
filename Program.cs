using System;
using System.Collections.Generic; //Enables list
using System.Linq;

namespace AppliedWebArcitechture_ConsoleQuiz
{
    class Program
    {
        static void Main(string[] args)
        {

            var allQuizItems = QuizHelper.GetAllQuizItems();

            //Variables for result
            var rightAnswers = 0;

            //List for random non repeating numbers
            var numberList = new List<int>(); //number of q
            var random = new Random(); //randomize questions
            int randomInt; //has to be 5

            //Color edit in terminal
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("\n   Welcome to the quiz!\n\nPlease enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hey " + name + "! Lets start...");

            //Loop through and randomize 5/10 questions
            for (int i = 1; i < 6; i++) //makes the int less than 5, i++ continues loop to next q
            {
                //Get 5 random non repeating numbers to use as index
                randomInt = random.Next(0, 10);
                if(!numberList.Contains(randomInt))
                {
                    numberList.Add(randomInt);
                    //Get questions
                    Console.WriteLine(i + ". " + allQuizItems[randomInt].Question + "\n1. " + allQuizItems[randomInt].Answers[0] + "\n2. " + allQuizItems[randomInt].Answers[1] + "\n3. " + allQuizItems[randomInt].Answers[2]);
                    var keyAnswer = 0;
    
                    while(keyAnswer != 1 && keyAnswer !=2 && keyAnswer != 3) //does key answers, solutions & add amount right
                    {
                        var keyStroke = Console.ReadKey();
                        int.TryParse(keyStroke.KeyChar.ToString(), out keyAnswer);

                        if(keyAnswer == 1 || keyAnswer == 2 || keyAnswer == 3){
                            if(allQuizItems[randomInt].CorrectAnswer == keyAnswer){
                                rightAnswers++;
                                Console.WriteLine("\n correct");
                            }
                            else {
                                Console.WriteLine(" try again");
                            }
                            break;
                        }
                        else{
                            Console.WriteLine("Try typing 1,2 or 3");
                        }
                    } 
                }
                else{
                    i--; //if q is used, it chooses another
                }
            }

            //End screen results + custom msg
            var precentage = ((double)rightAnswers / 5) * 100;
            Console.WriteLine(name + ", You scored " + rightAnswers + "/5 (" + precentage + "%)");

            if(rightAnswers <= 2)
            {
                Console.WriteLine("UR DUMB!");
            }
            else if(rightAnswers == 3)
            {
                Console.WriteLine("You are average!");  
            }
            else
            {
                Console.WriteLine("You are AMAZING!");
            }
            
            Console.WriteLine("Press any ket to exit the quiz");
            Console.ReadKey();

            //Edit back color to original
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            //Exit quiz
            Console.Clear();
            Environment.Exit(0); 
        }
    }
}
