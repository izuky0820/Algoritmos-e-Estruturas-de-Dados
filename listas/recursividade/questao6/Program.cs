using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao6
{
    internal class Program
    {
        static double CalcularSerie(int n)
        {
            if(n == 1) { return 1.0 + Math.Pow(1.0, 2) / 1.0; }
            else { return (1.0 + Math.Pow(n, 2)) / n + CalcularSerie(n - 1); }
        }

        static void Main(string[] args)
        {
            Console.Write(CalcularSerie(3));
        }
    }
}
