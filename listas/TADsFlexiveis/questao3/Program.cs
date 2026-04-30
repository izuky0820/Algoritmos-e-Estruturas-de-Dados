using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao3
{
    class Arquivo
    {
        private string nome;
        private int num;

        public Arquivo(string nome, int num)
        {
            this.nome = nome;
            this.num = num;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        public override string ToString()
        {
            return Nome + " " + Num;
        }
    }
    class Celula
    {
        private Arquivo elemento;
        private Celula prox;

        public Celula(Arquivo elemento)
        {
            this.elemento = elemento;
            this.prox = null;
        }
        public Celula()
        {
            this.elemento = null;
            this.prox = null;
        }
        public Celula Prox
        {
            get { return prox; }
            set { prox = value; }
        }
        public Arquivo Elemento
        {
            get { return elemento; }
            set { elemento = value; }
        }
    }

    class Fila
    {
        private Celula primeiro, ultimo;

        public Fila()
        {
            primeiro = new Celula();
            ultimo = primeiro;
        }

        public void Inserir(Arquivo x)
        {
            Celula tmp = new Celula(x);
            ultimo.Prox = tmp;
            ultimo = ultimo.Prox;

        }

        public String Remover()
        {
            if(primeiro == ultimo) { throw new Exception("Erro!"); }

            primeiro = primeiro.Prox;
            Arquivo elemento = primeiro.Elemento;
            return elemento.Nome;
        }

        public void Mostrar()
        {
            for(Celula i = primeiro.Prox; i != null; i = i.Prox)
            {
                Console.WriteLine(i.Elemento);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            int op, num;
            string nome;
            Fila f = new Fila();
            do
            {
                Console.WriteLine("Op:");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        nome = Console.ReadLine();
                        num = int.Parse(Console.ReadLine());
                        Arquivo a = new Arquivo(nome, num);
                        f.Inserir(a);
                        break;
                    case 2:
                        Console.WriteLine(f.Remover());
                        break;
                    case 3:
                        f.Mostrar();
                        break;
                    default:
                        break;
                }
            }
            while (op != 4);
        }
    }
}
