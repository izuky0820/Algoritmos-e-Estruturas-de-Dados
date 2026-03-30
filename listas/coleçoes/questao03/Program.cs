using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> pista = new Queue<string>();
            int op;
            string aviao;
            do
            {
                Console.WriteLine("Op:");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine(pista.Count);
                        break;
                    case 2:
                        Console.WriteLine(pista.Dequeue());
                        break;
                    case 3:
                        aviao = Console.ReadLine();
                        pista.Enqueue(aviao);
                        break;
                    case 4:
                        foreach(string i in pista)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case 5:
                        Console.WriteLine(pista.Peek());
                        break;
                    default:
                        break;

                }

            }
            while (op != 6);
        }
    }
}
