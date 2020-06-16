using System;
using Logika;

namespace Logika
{
     public static class Class1
    {
        public static void MojeMenu()
        {
            Console.Title = "Menu";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\t Witam w grze!");
                Console.WriteLine("\tKółko i krzyżyk");
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("(Naciśnij (1-3) aby rozpocząć działania)");
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("\t1-Rozpocznij grę");
                Console.WriteLine("\t2-Zasady gry");
                Console.WriteLine("\t3-Zakończ");

                ConsoleKeyInfo klawisz = Console.ReadKey();
                switch (klawisz.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        WBudowie();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        WBudowie();
                        break;
                    case ConsoleKey.Escape:
                    case ConsoleKey.D3:
                        Environment.Exit(0);
                        break;
                    default:
                        break;

                }
            }
        }
        static void WBudowie()
        {
            Console.Write("puste");
            Console.ReadKey();
        }
    }    
}

