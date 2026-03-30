using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> palavras = new Dictionary<string, int>();

            string frase = Console.ReadLine();
            string[] vet = frase.Split(' ');
            foreach (string i in vet)
            {
                string p = i.ToLower();
                if (palavras.ContainsKey(p)){ palavras[p]++; }
                else { palavras[p] = 1; }
            }

            foreach(KeyValuePair<string,int> item in palavras)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }


        }
    }
}
