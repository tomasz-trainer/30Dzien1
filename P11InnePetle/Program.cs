using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11InnePetle
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            int x;
            //1  while 
            while (true)
            {
                if (true)
                {
                    break;
                }
            }


            //2 do while

            string zdanie = "ala ma kota";
            int i = 0;
            // wypisz kolejne znaki w zdaniu
            // zadkładamy , że nasze zdanie bedzie zawierać przynajmniej jeden znak

            do
            {
                Console.WriteLine(zdanie.Substring(i,1));
                i++;
            }
            while (i<zdanie.Length); // sprawdzamy czy mozemy iść dalej 
                                     //do-while wykona sie przynajmniej raz 


            // pela 3: for
            int k1 = 0;
            while (k1 < zdanie.Length)
            {
                k1+=2;
            }

            for (int k = 0; k < zdanie.Length; k+=2)
            {
                Console.WriteLine(zdanie.Substring(k,1));
            }
            
            // mozemy modyfikowac parametry petli for 
            for (int k = zdanie.Length - 1; k > -1; k--)
            {
                Console.WriteLine(zdanie.Substring(k, 1));
            }

            //  // staramy sie unikac >= lub <=
            for (int k = zdanie.Length - 1; k >= 0; k--)
            {
                Console.WriteLine(zdanie.Substring(k, 1));
            }

            // czesto bedzie tak, ze bedzie iterowac po wszystkich elementach zbioru 

            foreach (var literka in zdanie)
            {
                Console.WriteLine(literka);
            }

            // w kazdej z petli mozemy uzyc słów: break (zakoncz petle)
            // oraz continue (przejdz do nastepnej iteracji)

            //ala ma kota
            foreach (var literka in zdanie)
            {
                if (literka == 'm')
                {
                    continue;
                }
                Console.WriteLine(literka);
            }

            // podsumowanie:
            // while, do-while, for, foreach
            // break, continue

        }
    }
}
