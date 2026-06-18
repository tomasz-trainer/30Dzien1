using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09Petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 0;

            while (k< 10)
            {
                k++;
                Console.WriteLine(k);
            }

            // zastanaowmy sie nad problemem z zdania p04

            

            string rownanie = "10 200 400";
             
            int pozycjaSpacji= -1;
            int i = 0;
            while (i < rownanie.Length) 
            {
                if (rownanie.Substring(i, 1) == " ")
                    pozycjaSpacji = i;
                
                i++;
            }


            // to jest algorytm ktory dziala jak podobnie jak lastIndexOf


            // chcemy zrobic dokładnie index of 
            pozycjaSpacji = -1;
            i = 0;
            while (i < rownanie.Length)
            {
                if (rownanie.Substring(i, 1) == " ")
                {
                    pozycjaSpacji = i;
                    i = rownanie.Length;
                }

                i++;
            }
            //

            // chcemy zrobic dokładnie index of 
            pozycjaSpacji = -1;
            i = 0;
            bool dziala = true;
            while (dziala)
            {
                if (rownanie[i] == ' ')
                {
                    pozycjaSpacji = i;
                    dziala = false;
                }

                i++;
            }

            string napis = "ala ma kota";
            char znak = 'n';
        }
    }
}
