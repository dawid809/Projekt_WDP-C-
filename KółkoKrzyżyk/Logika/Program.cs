using System;


namespace Logika
{
    public class Program
    {
        //Tworzę macierz 3x3 oraz deklaruje gracza, ruch i wygraną
        static int[,] tablica = new int[3, 3];
        static int gracz = 1;
        static int ruch = 0;
        static int wygrana = 0;

        public static void StartGry()
        {
             // Gdy nie ma zwycięzy ponów próbę
            while (wygrana == 0)
            {
                Console.Clear();
             //Jeśli po 9 ruchach nie ma zwycięzcy przerwij 
                if (ruch == 9)
                {
                    wygrana = 2;
                    break;
                }
                PokazTablice();
                PonowProbe();
            }
            //Po zakończeniu gry pokaż ostateczną planszę i komunikat o wyniku
            PokazTablice();
            Console.ForegroundColor = ConsoleColor.Green;
            if (wygrana == 1) Console.WriteLine("\nZwycięstwo! Gratulacje dla gracza {0}.\n", gracz);
            else Console.WriteLine("\nRemis.");
            Console.ResetColor();
            Console.ReadLine();

        }
                 // Tworzenie obkietów w mojej tablicy 
        static void PokazTablice()
        {
            string znak;
            for (int x = 0; x < 3; x++)
            {
                
                for (int y = 0; y < 3; y++)
                {
                    znak = "   ";
                    if (tablica[x, y] != 0) znak = (tablica[x, y] == 1) ? " X " : " O ";
                    Console.Write(znak);
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (y < 2) Console.Write("|");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                if (x < 2) Console.WriteLine("-----------");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        static void PonowProbe()
        {
            Console.Write("\nGracz {0}, Wybierz pole od 1 do 9: \n", gracz);
            int wybor = Convert.ToInt32(Console.ReadLine());
            PodajRuch(wybor);
        }
        static void PodajRuch(int wybor)
        {     //Deklaracja ruchu po tablicy (jeśli zajęte ponow)
            int x = (wybor - 1) / 3;
            int y = (wybor - 1) % 3;

            if (tablica[x, y] == 0)
            {
                tablica[x, y] = gracz;
                SprawdzWygrana();
                if (wygrana == 0)
                {
                    gracz = (gracz == 1) ? 2 : 1;
                    ruch++;
                }
            }
            else
            {
                Console.WriteLine("\nPole zajęte, spróbuj ponownie");
                PonowProbe();
            }
        }
        static void SprawdzWygrana()
        {
            //Sprawdza warunki wygranej (wiersze, kolumny oraz przekątne)
            for (int x = 0; x < 3; x++)
            {
                if (tablica[x, 0] > 0 && tablica[x, 0] == tablica[x, 1] && tablica[x, 1] == tablica[x, 2])
                {
                    wygrana = 1;
                    return;
                }
            }
            for (int y = 0; y < 3; y++)
            {
                if (tablica[0, y] > 0 && tablica[0, y] == tablica[1, y] && tablica[1, y] == tablica[2, y])
                {
                    wygrana = 1;
                    return;
                }
            }
            if (tablica[0, 0] > 0 && tablica[0, 0] == tablica[1, 1] && tablica[1, 1] == tablica[2, 2])
            {
                wygrana = 1;
                return;
            }
            if (tablica[2, 0] > 0 && tablica[2, 0] == tablica[1, 1] && tablica[1, 1] == tablica[0, 2])
            {
                wygrana = 1;
                return;
            }
        }
    }
}