using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14ZadanieZgadywanka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wylosowanaLiczba = new Random().Next(1, 11);
            int liczbaProb = 0;
            int ostatniaRoznica = int.MaxValue;

            Console.WriteLine("Zgadnij liczbe od 1 do 10.");

            while (true)
            {
                Console.WriteLine("Podaj liczbę:");
                int zgadywanaLiczba = Convert.ToInt32(Console.ReadLine());

                liczbaProb++;

                //int roznica;
                //if (zgadywanaLiczba > wylosowanaLiczba)
                //    roznica = zgadywanaLiczba - wylosowanaLiczba;
                //else
                //    roznica = wylosowanaLiczba - zgadywanaLiczba;
                int roznica = Math.Abs(wylosowanaLiczba - zgadywanaLiczba);
                if (roznica == 0)
                {
                    Console.WriteLine($"Gratulacje! Zgadłeś Liczbę. Liczba Prób: {liczbaProb}");
                    break;
                }
                else
                {
                    if (roznica < ostatniaRoznica)
                        Console.WriteLine("Ciepło");
                    else
                        Console.WriteLine("Zimno");

                    ostatniaRoznica = roznica;
                }
            }
            Console.ReadKey();
        }
    }
}
