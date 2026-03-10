using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao7
{
    internal class Program
    {
        static int Soma(int m, int n)
        {
            if(m == n)
            {
                return n;
            }
            else { return n + Soma(m ,n - 1); }
        }

        static void Main(string[] args)
        {
            Console.Write(Soma(1, 3));
        }
    }
}
