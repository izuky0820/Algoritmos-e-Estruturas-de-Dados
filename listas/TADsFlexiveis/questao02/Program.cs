using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao02
{
    class Celula
    {
        private int elemento;
        private Celula prox;
        public Celula(int elemento)
        {
            this.elemento = elemento;
            this.prox = null;
        }
        public Celula()
        {
            this.elemento = 0;
            this.prox = null;
        }
        public Celula Prox
        {
            get { return prox; }
            set { prox = value; }
        }
        public int Elemento
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

        public void Inserir(int x)
        {
            Celula tmp = new Celula(x);
            tmp.Prox = topo;
            topo = tmp;
            tam++;
        }

        public int Remover()
        {
            if (topo == null) { throw new Exception("Erro!"); }

            int elemento = topo.Elemento;
            topo = topo.Prox;
            tam--;
            return elemento;
        }

        public void Mostrar()
        {
           
            for (Celula i = topo; i != null; i = i.Prox)
            {
                Console.Write(i.Elemento);
            }
           
}

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha p = new Pilha();
            int num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
               p.Inserir(num % 8);
               num /= 8;
            }
            p.Mostrar();
           
        }
    }
}
