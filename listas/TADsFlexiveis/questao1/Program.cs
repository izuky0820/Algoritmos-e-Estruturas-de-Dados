using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao1
{
    class Celula
    {
        private char elemento;
        private Celula prox;
        public Celula(char elemento)
        {
            this.elemento = elemento;
            this.prox = null;
        }
        public Celula()
        {
            this.elemento = ' ';
            this.prox = null;
        }
        public Celula Prox
        {
            get { return prox; }
            set { prox = value; }
        }
        public char Elemento
        {
            get { return elemento; }
            set { elemento = value; }
        }
    }

    class Pilha
    {
        private Celula topo;
        private int tam;

        public Pilha()
        {
            topo = null;
            tam = 0;
        }

        public int Tam
        {
            get { return tam; }
            set { tam = value; }
        }

        public void Inserir(char x)
        {
            Celula tmp = new Celula(x);
            tmp.Prox = topo;
            topo = tmp;
            tam++;
        }

        public char Remover()
        {
            if (topo == null) { throw new Exception("Erro!"); }

            char elemento = topo.Elemento;
            topo = topo.Prox;
            tam--;
            return elemento;
        }
    }

    internal class Program
    {
        static string Verifica(string x)
        {
            Pilha p = new Pilha();
            char topo;
            foreach (char i in x)
            {
                if (i == '(' || i == '[') { p.Inserir(i); }
                else if (i == ')' || i == ']')
                {
                    if (p.Tam == 0) { return "errada"; }
                    topo = p.Remover();
                    if ((i == ')' && topo != '(') || (i == ']' && topo != '[')) { return "errada"; }
                    else if (i == ']' && topo != '[') { return "errada"; }
                }
            }
            if (p.Tam == 0) { return "correta"; }
            else { return "errada"; }

        }

        static void Main(string[] args)
        {
            string entrada = Console.ReadLine();
            Console.WriteLine(Verifica(entrada));
            
        }
    }
}
