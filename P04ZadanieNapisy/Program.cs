using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieNapisy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- część 1 ---");
            Console.WriteLine("Podaj kolejno dwie liczby");

            int liczba1 = Convert.ToInt32(Console.ReadLine());
            int liczba2 = Convert.ToInt32(Console.ReadLine());

            int suma = liczba1 + liczba2;

            int liczbaZnakow = Convert.ToString(suma).Length;

            string raport1 = "wynik " + suma + " złozony jest z:"
                + liczbaZnakow + " znaków";

            string raport2 = $"wynik {suma} złożony jest z: {liczbaZnakow} znaków";

            string raport3 = string.Format("wynik {0} złożony jest z {1} znaków", suma, liczbaZnakow);
           
            Console.WriteLine(raport1);

            Console.WriteLine("--- część 2 ---");

            Console.WriteLine("Podaj dwie liczby oddzielone spacją");
            string liczby = Console.ReadLine();
            //200 10
            //012345

            int pozycjaSpacji = liczby.IndexOf(" ");// 3

            int nowaLiczba1 = Convert.ToInt32(liczby.Substring(0, pozycjaSpacji));
            int nowaLiczba2 = Convert.ToInt32(liczby.Substring(pozycjaSpacji + 1));

            int nowaSuma = nowaLiczba1 + nowaLiczba2;

            Console.WriteLine(nowaSuma);
            Console.ReadKey();
        }
    }
}
