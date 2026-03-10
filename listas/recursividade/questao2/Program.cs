using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao2
{
    internal class Program
    {
        static int Fib(int n)
        {
            int resp;
            if(n == 0 || n == 1) { resp = 1; }
            else { resp = Fib(n - 2) + Fib(n - 1); }
            return resp;
        }
        static void Main(string[] args)
        {
            int valor = Fib(4);
            Console.Write(valor);

        }
    }
}
