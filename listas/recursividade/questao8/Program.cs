using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao8
{
    internal class Program
    {
        static void Binario(int n)
        {
            if(n == 1) { Console.Write(n + " "); }
            else
            {
             
                Binario(n / 2);
                Console.Write(n % 2 + " ");
            }
        }

        static void Main(string[] args)
        {
            Binario(4);
        }
    }
}
