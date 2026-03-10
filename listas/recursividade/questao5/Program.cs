using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao5
{
    internal class Program
    {
        static int Potencia(int a, int n)
        {
            int resp;
            if(n == 0) { resp = 1; }
            else
            {
                resp = a * Potencia(a, n - 1);
            }
            return resp;

        }

        static void Main(string[] args)
        {
            Console.Write(Potencia(2,2));
        }
    }
}
