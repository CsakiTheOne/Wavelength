﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wavelength
{
    static class Game
    {
        static string player1;
        static string player2;

        public static void Menu()
        {
            Console.Write("1. játékos neve: ");
            player1 = Console.ReadLine();
            Console.Write("2. játékos neve: ");
            player2 = Console.ReadLine();

            ConsoleKey key;
            do
            {
                Console.Clear();

                Console.WriteLine("Wavelength\n\r");

                Console.WriteLine("1. Egy gyors kérdés");
                Console.WriteLine("2. 5 kérdés");
                Console.WriteLine($"3. Az összes! ({Questions.Default.Count})");
                Console.WriteLine("9. Kilépés");

                key = Console.ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.D1:
                        Gameplay(1);
                        break;
                    case ConsoleKey.D2:
                        Gameplay(5);
                        break;
                    case ConsoleKey.D3:
                        Gameplay(Questions.Default.Count);
                        break;
                }
            } while (key != ConsoleKey.D9);
        }

        static void Gameplay(int count)
        {
            List<Question> questions = PrepareQuestions(count);

            foreach (Question question in questions)
            {
                Console.Clear();
                Console.WriteLine(FormatText(question.ToString()));

                char player1 = Console.ReadKey().KeyChar;
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(".");

                char player2 = Console.ReadKey().KeyChar;
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(FormatText("..\n\r%pr nyomj meg egy gombot!"));
                Console.ReadKey();

                Console.SetCursorPosition(0, Console.CursorTop);
                Console.WriteLine($"Válaszok:\t{player1} {player2}\t\t");
                Console.ReadKey();
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(".");
                Console.ReadKey();
            }
        }

        static List<Question> PrepareQuestions(int count)
        {
            List<Question> pool = new List<Question>(Questions.Default);
            List<Question> questions = new List<Question>();

            Random rdm = new Random();
            int lastIndex;
            for (int i = 0; i < count; i++)
            {
                lastIndex = rdm.Next(pool.Count);
                questions.Add(pool[lastIndex]);
                pool.RemoveAt(lastIndex);
            }

            return questions;
        }

        static string FormatText(string text)
        {
            Random rdm = new Random();
            text = text.Replace("%pr", rdm.Next(2) == 0 ? player1 : player2);
            text = text.Replace("%p1", player1);
            text = text.Replace("%p2", player2);
            return text;
        }
    }
}
