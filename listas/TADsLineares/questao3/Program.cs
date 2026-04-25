using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao3
{
    class Pilha
    {
        private double[] array;
        private int topo;

        public Pilha(int tam)
        {
            array = new double[tam];
            topo = 0;
        }

        public void InserirFim(double x)
        {
            if (topo >= array.Length)
                throw new Exception("Erro!");

            array[topo] = x;

            topo++;
        }

        public double RemoverFim()
        {
            if (topo == 0)
                throw new Exception("Erro!");
            topo--;
            return array[topo];
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string expr = Console.ReadLine();

            Pilha pilha = new Pilha(expr.Length);

            for (int i = 0; i < expr.Length; i++)
            {
                char c = expr[i];

                if (char.IsDigit(c))
                {
                    double num = Char.GetNumericValue(c);
                    pilha.InserirFim(num);
                }
                else
                {
                    double a = pilha.RemoverFim();
                    double b = pilha.RemoverFim();
                    double resultado = 0;

                    switch (c)
                    {
                        case '+':
                            resultado = b + a;
                            break;
                        case '-':
                            resultado = b - a;
                            break;
                        case '*':
                            resultado = b * a;
                            break;
                        case '/':
                            resultado = b / a;
                            break;
                    }

                    pilha.InserirFim(resultado);
                }
            }
            Console.WriteLine(pilha.RemoverFim());

        }
    }
}
