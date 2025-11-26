using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProg_TriviaGame_BenF
{
    internal class Program
    {
        static string playerName;
        static int curQuestion = 0;
        static int QuestionsCorrect = 0;
        static bool stillPlaying = true;

        static List<string> Questions = new List<string>();
        static List<string[]> Answers = new List<string[]>();

        static void AddQuestions()
        {
            Questions.Add("Question 1: What is the most commonly used index variable for the first 'For' Loop in a program?");

            Questions.Add("Question 2: How do you declare a list of strings?");

            Questions.Add("Question 3: ");

            Questions.Add("Question 4: ");

            Questions.Add("Question 5: ");

            Questions.Add("Question 6: ");

            Questions.Add("Question 7: ");

            Questions.Add("Question 8: ");

            Questions.Add("Question 9: ");

            Questions.Add("Question 10: ");
        }

        static void AddAnswers()
        {
            //index fix
            string[] QuestionA = { "1:", "2:", "3:", "4: " };
            Answers.Add(QuestionA);

            //question answers start here

            string[] Question1A = { "1: i", "2: a", "3: j", "4: n" };
            Answers.Add(Question1A);

            string[] Question2A = { "1: static List<string> Questions = new List<string>;", "2: static List<string> Questions = List();", "3: static List<string> name;", "4: static List<string> name = new List<string>();" };
            Answers.Add(Question2A);

            string[] Question3A = { "1", "2", "3", "4" };
            Answers.Add(Question3A);

            string[] Question4A = { "1", "2", "3", "4" };
            Answers.Add(Question4A);

            string[] Question5A = { "1", "2", "3", "4" };
            Answers.Add(Question5A);

            string[] Question6A = { "1", "2", "3", "4" };
            Answers.Add(Question6A);

            string[] Question7A = { "1", "2", "3", "4" };
            Answers.Add(Question7A);

            string[] Question8A = { "1", "2", "3", "4" };
            Answers.Add(Question8A);

            string[] Question9A = { "1", "2", "3", "4" };
            Answers.Add(Question9A);

            string[] Question10A = { "1", "2", "3", "4" };
            Answers.Add(Question10A);

        }

        static void MultipleChoice(int question)
        {
            //answer key
            int answer;

            if(question == 1)
            {
                answer = 1;
            }

            else if (question == 2)
            {
                answer = 4;
            }

            else if (question == 3)
            {
                answer = 1;
            }

            else if (question == 4)
            {
                answer = 2;
            }

            else if (question == 5)
            {
                answer = 2;
            }

            else if (question == 6)
            {
                answer = 4;
            }

            else if (question == 7)
            {
                answer = 3;
            }

            else if (question == 8)
            {
                answer = 1;
            }

            else if (question == 9)
            {
                answer = 3;
            }

            else 
            {
                answer = 4;
            }

            //get answer
            Console.WriteLine("Choose and answer (1-4)");
            while (true)
            {
                ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.D1)
                {
                    if(answer == 1)
                    {
                        QuestionsCorrect += 1;
                    }
                    break;
                }

                else if (keyInfo.Key == ConsoleKey.D2)
                {
                    if (answer == 2)
                    {
                        QuestionsCorrect += 1;
                    }
                    break;
                }

                else if (keyInfo.Key == ConsoleKey.D3)
                {
                    if (answer == 3)
                    {
                        QuestionsCorrect += 1;
                    }
                    break;
                }

                else if (keyInfo.Key == ConsoleKey.D4)
                {
                    if (answer == 4)
                    {
                        QuestionsCorrect += 1;
                    }
                    break;
                }

                else
                {
                    continue;
                }
            }
        }

        static void ShowHUD()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Player: {playerName}             Current Question: {curQuestion}              Score: {QuestionsCorrect} / {Questions.Count} ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Main(string[] args)
        {
            AddQuestions();
            AddAnswers();

            while (stillPlaying)
            {
                foreach (string Question in Questions)
                {
                    curQuestion += 1;
                    ShowHUD();

                    Console.WriteLine(Question);
                    Console.WriteLine(" ");

                    Console.WriteLine(string.Join("         ", Answers[curQuestion]));
                    Console.WriteLine(" ");

                    MultipleChoice(curQuestion);
                    Console.Clear();
                }

                while (true)
                {
                    Console.WriteLine("Do you want to play again? (Y/N)");

                    ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
                    keyInfo = Console.ReadKey(true);

                    if (keyInfo.Key == ConsoleKey.Y)
                    {
                        curQuestion = 0;
                        Console.Clear();
                        break;
                    }

                    else if (keyInfo.Key == ConsoleKey.N)
                    {
                        Console.Clear();
                        stillPlaying = false;
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Enter 'Y' for Yes or 'N' for No");
                        Console.ReadKey(true);
                        Console.Clear();
                    }
                }
            }

            Console.WriteLine("Bye Bye");
        }
    }
}
