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
    public class Class1
    {
        public static void Main()
        {
            Console.Title = "Menu Kółko i Krzyżyk";
            while (true)
            {        //Tworzę menu w konsoli i dodaję 3 możliwe warianty 
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

                 // Przypisuje odpowiednie klawisze do poprzednich opcji
                ConsoleKeyInfo klawisz = Console.ReadKey();

                switch (klawisz.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Program.StartGry();
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
          //  Przetrzymuje informacje o zasadach Gry (2 opcja)
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
    }
}

