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
        static int QuestionsCorrect = 0;
        static bool stillPlaying = true;

        static List<string> Questions = new List<string>();

        static void AddQuestions()
        {
            Questions.Add("Question 1: ");

            Questions.Add("Question 2: ");

            Questions.Add("Question 3: ");

            Questions.Add("Question 4: ");

            Questions.Add("Question 5: ");

            Questions.Add("Question 6: ");

            Questions.Add("Question 7: ");

            Questions.Add("Question 8: ");

            Questions.Add("Question 9: ");

            Questions.Add("Question 10: ");
        }

        static void MultipleChoice(int answer)
        {
            Console.WriteLine("Choose and answer (1-4)");
            while (true)
            {
                ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Oem1)
                {
                    if(answer == 1)
                    {
                        QuestionsCorrect += 1;
                    }
                    break;
                }

                else if (keyInfo.Key == ConsoleKey.Oem2)
                {
                    if (answer == 2)
                    {
                        QuestionsCorrect += 1;
                    }
                    break;
                }

                else if (keyInfo.Key == ConsoleKey.Oem3)
                {
                    if (answer == 3)
                    {
                        QuestionsCorrect += 1;
                    }
                    break;
                }

                else if (keyInfo.Key == ConsoleKey.Oem4)
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
            Console.WriteLine($"Player: {playerName}                Score: {QuestionsCorrect} / {Questions.Count} ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Main(string[] args)
        {
            AddQuestions();

            while (stillPlaying)
            {
                foreach (string Question in Questions)
                {
                    ShowHUD();
                    Console.WriteLine(Question);
                    Console.ReadKey(true);
                    Console.Clear();
                }

                while (true)
                {
                    Console.WriteLine("Do you want to play again? (Y/N)");

                    ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
                    keyInfo = Console.ReadKey(true);

                    if (keyInfo.Key == ConsoleKey.Y)
                    {
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
