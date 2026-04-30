using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao4
{
    class Celula
    {
        private string elemento;
        private Celula prox;

        public Celula(string elemento)
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
        public string Elemento
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

        public void Inserir(string x)
        {
            Celula tmp = new Celula(x);
            ultimo.Prox = tmp;
            ultimo = ultimo.Prox;

        }

        public String Remover()
        {
            if (primeiro == ultimo) { throw new Exception("Erro!"); }

            primeiro = primeiro.Prox;
            string elemento = primeiro.Elemento;
            return elemento;
        }

        public void Mostrar()
        {
            for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            {
                Console.WriteLine(i.Elemento);
            }
        }

        public bool Pesquisar(string nome)
        {
            for(Celula i = primeiro.Prox; i != null; i = i.Prox)
            {
                if(i.Elemento == nome) { return true; }
            }
            return false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            string nome;
            Fila Ic = new Fila();
            Fila m = new Fila();

            do
            {
                Console.WriteLine("Op:");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        nome = Console.ReadLine();
                        Ic.Inserir(nome);
                        break;
                    case 2:
                        nome = Console.ReadLine();
                        m.Inserir(nome);
                        break;
                    case 3:
                        Console.WriteLine(Ic.Remover());
                        break;
                    case 4:; ;
                        Console.WriteLine(m.Remover());
                        break;
                    case 5:
                        Ic.Mostrar();
                        break;
                    case 6:
                        m.Mostrar();
                        break;
                    case 7:
                        nome = Console.ReadLine();
                        if (Ic.Pesquisar(nome)) { Console.WriteLine('S'); }
                        else { Console.WriteLine('N'); }
                        break;
                    case 8:
                        nome = Console.ReadLine();
                        if (m.Pesquisar(nome)) { Console.WriteLine('S'); }
                        else { Console.WriteLine('N'); }
                        break;
                    default:
                        break;
                }
            }
            while (op != 9);
        }
    }
}
