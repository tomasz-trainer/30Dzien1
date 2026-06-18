using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1; // operator przypisania 
            bool czy = a == 1; // == operator porównania 

            a = a + 1;
            a++; // zwieksz o 1 (inkrementacja)
            a--; // zmniejsz o 1 (dekrementacja)

            a += 5; // zwieksz np. o 5 

            a *= 2;// przemnoz przez 2 czyli to samo co a=a*2

            a -= 6;// zmniejsz o 6 

            a /= 2; // przedziel przez 2 

            bool czyMniejsze = a < 5; // czy mniejsze od...

            bool czyWiekszeLubRowne = a >= 5; // czy wieksze lub równe ..

            bool b1 = a < 5 || a > 10; // czy a jest mniejsze od 5 lub wieksze od 10

            bool b2 = a > 5 && a < 10; // i 

            bool b3 = a != 5; // różne od 

            bool b4 = !(a == 5); // ! to zaprzeczenie 

            int ax = 10 % 2; // operator modulo - reszta z dzielenia 10 przez 2, czyli 0, bo 10 jest podzielne przez 2 bez reszty
        }
    }
}
