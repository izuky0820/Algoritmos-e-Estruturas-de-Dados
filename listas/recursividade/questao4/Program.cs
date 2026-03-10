using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao4
{
    internal class Program
    {
        static void Imprimir(int n)
        {
            if(n == 0) { Console.Write(n + " "); }
            else
            {
                Imprimir(n - 1);
                Console.Write(n + " ");
            }
        }
        static void Main(string[] args)
        {
            Imprimir(6);

        }
    }
}
