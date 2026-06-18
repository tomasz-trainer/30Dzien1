using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13ZadanieKalkulatorBMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoja wage w kilogramach");
            int waga = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj swój wzrost w centymetrach");
            double wzrost = Convert.ToInt32(Console.ReadLine());

            //double a = 3.0/10; 
            double d = Convert.ToDouble(10) / 3;

            //double bmi = waga/(wzrost/100 * wzrost/100);
            double bmi = waga / Math.Pow(wzrost / 100, 2);

            //  Console.WriteLine($"Twoje Bmi wynosi: {bmi:0.000}");
            Console.WriteLine($"Twoje Bmi wynosi: {bmi:F2}");


            if (bmi < 18.5)
                Console.WriteLine("Masz niedowage");
            else if (bmi < 25)
                Console.WriteLine("Twoja waga jest w normie");
            else if (bmi < 30)
                Console.WriteLine("Masz nadwage");
            else if (bmi < 35)
                Console.WriteLine("Masz Otyłość I stopnia");
            else if (bmi < 40)
                Console.WriteLine("Masz Otyłość II stopnia (kliniczna)");
            else
                Console.WriteLine("Masz Otyłość III stopnia (ekstremalna)");
        }
    }
}
