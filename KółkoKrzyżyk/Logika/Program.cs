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
                    if (y < 2) Console.Write("|");
                }
                Console.WriteLine();
                if (x < 2) Console.WriteLine("-----------");
            }
        }

        static void PonowProbe()
        {
            int wybor = Convert.ToInt32(Console.ReadLine());
        }
    }
}