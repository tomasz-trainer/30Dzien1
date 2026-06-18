using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Debugowanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string napis  = "ala ma kota";

            int a = 10;
            int b = 5;

            b = b * 2;
            b++;
            a = b + napis.Length;
        }
    }
}
