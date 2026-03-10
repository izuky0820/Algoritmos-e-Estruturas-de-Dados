using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao1
{
    internal class Program
    {
        static int Fat(int n)
        {
            int resp;
            if (n == 0) { resp = 1; }
            else { resp = n * Fat(n - 1); }
            return resp;
        }

        static void Main(string[] args)
        {
            int n, f;
            n = 4;
            f = Fat(n);
            Console.Write(f);
        }
    }
}
