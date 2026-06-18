using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07InstrukcjeWarunkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wzrost");
            int wzrost = Convert.ToInt32(Console.ReadLine());

            // wypisz "wysoki" gdy wzrost wyższy niz 180 wpp. wypisz niski 


            bool c1 = wzrost > 180;

            if (c1)
            {
                Console.WriteLine("wysoki");
            }
            else
            {
                Console.WriteLine("niski");
            }


            if(c1)
                Console.WriteLine($"twój wzrost to {wzrost} i jesteś wysoki");
            else if (wzrost > 160)
                Console.WriteLine($"twój wzrost to {wzrost} i jesteś średni");
            else if (wzrost > 150)
                Console.WriteLine($"twój wzrost to {wzrost} i jesteś niski");
            else
                Console.WriteLine($"twój wzrost to {wzrost} i jesteś bardzo niski");


            // zapobieganie powtarzajacym sie kawalom kodu 
            string typ;
            if (wzrost > 180)
                typ = "wysoki";
            else if (wzrost > 160)
                typ = "średni";
            else if (wzrost > 150)
                typ = "niski";
            else
                typ = "bardzo niski";

            string raport = $"twój wzrost to {wzrost} i jesteś {typ}";


            // operator trój-argumentowy 
            string wyn;
            if (wzrost > 180)
                wyn = "wysoki";
            else
                wyn = "niski";

            string wyn1 = wzrost > 180 ? "wysoki" : "niski";

            string wyn2 = wzrost > 180 ? "wysoki" : wzrost < 160 ? "niski" : "średni";



        }
    }
}
