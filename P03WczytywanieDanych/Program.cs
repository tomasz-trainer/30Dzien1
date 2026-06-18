using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03WczytywanieDanych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj jak sie nazywasz");
            string imie = Console.ReadLine();//.ToUpper();

            imie = imie.Substring(0, 1).ToUpper() + imie.Substring(1).ToLower();

            //imie = imie.ToUpper();

            Console.WriteLine(imie);

            Console.WriteLine("Podaj wiek");
            string wiek = Console.ReadLine();

            //  wiek = wiek + 1;

            int wiekInt = Convert.ToInt32(wiek) + 1;

            

            Console.WriteLine("Twoj wiek to za rok: " + wiekInt);
        }
    }
}
