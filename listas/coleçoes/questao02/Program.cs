using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace questao02
{

    internal class Program
    {
        public static string Verifica(string s)
        {
            Stack<char> pilha = new Stack<char>();
            foreach (char i in s)
            {
                if (i == '(' || i == '[') { pilha.Push(i); }
                else if (i == ')' || i == ']')
                {
                    if (pilha.Count == 0) { return "errada"; }

                    char topo = pilha.Pop();
                    if ((i == ')' && topo != '(') || (i == ']' && topo != '[')) { return "errada"; }
                    else if(i == ']' && topo != '[') { return "errada"; }
                }
               
            }
            if (pilha.Count == 0) { return "correta"; }
            else { return "errada"; }

        }
        static void Main(string[] args)
        {
            string sequencia = Console.ReadLine();
            Console.WriteLine(Verifica(sequencia));
        }
    }
}
