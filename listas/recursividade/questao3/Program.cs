using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao3
{
    internal class Program
    {
        static int Soma(int n)
        {
            int resp;
            if(n == 1) { resp = 1; }
            else { resp = n + Soma(n - 1); }
            return resp;
        }
        static void Main(string[] args)
        {
            int x = Soma(5);
            Console.Write(x);
        }
    }
}
