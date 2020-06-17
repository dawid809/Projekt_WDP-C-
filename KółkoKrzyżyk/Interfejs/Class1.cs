using System;
using Logika;

namespace Logika
{
    public enum OpcjeMenu
    {
        Rozpocznij,
        Zasady,
        Zakończ,
    }
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
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------");
                OpcjeMenu opcja1 = OpcjeMenu.Rozpocznij;
                Console.WriteLine($"\t1-" + opcja1);
                OpcjeMenu opcja2 = OpcjeMenu.Zasady;
                Console.WriteLine($"\t2-" + opcja2);
                OpcjeMenu opcja3 = OpcjeMenu.Zakończ;
                Console.WriteLine($"\t3-" + opcja3);

                ConsoleKeyInfo klawisz = Console.ReadKey();
                switch (klawisz.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        WBudowie();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        ZasadyGry();
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
        static void ZasadyGry()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\tZasady gry Kółko i Krzyżyk\n");
            Console.ResetColor();
            Console.WriteLine("----------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Gra toczy się na kwadratowej planszy (3x3) podzielonej na pola,");
            Console.WriteLine("na której dwóch graczy naprzemiennie stawia symbole X albo O.");
            Console.WriteLine("Nie można postawić symbolu na polu zajętym przez innego gracza,");
            Console.WriteLine("a wygrywa ten kto pierwszy zajmie 3 pola w rzędzie(poziomo, pionowo lub na ukos)");
            Console.WriteLine("W przypadku gdy nikt nie wygrał i zostały zajęte wszystkie pola na planszy, następuje remis.\n");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.ReadKey();
        }
        static void WBudowie()
        {
            Console.Write("puste");
            Console.ReadKey();
        }

    }
}

