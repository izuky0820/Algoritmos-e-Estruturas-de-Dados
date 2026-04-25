using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao4
{
    class Arquivo
    {
        private string nome;
        private int pags;

        public Arquivo(string nome, int pags)
        {
            this.nome = nome;
            this.pags = pags;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Pags
        {
            get { return pags; }
            set { pags = value; }
        }

        public override string ToString()
        {
            return Nome + " " + Pags;
        }


    }

    class Fila
    {
        Arquivo[] array;
        int primeiro, ultimo;

        public Fila(int tamanho)
        {
            array = new Arquivo[tamanho + 1];
            primeiro = ultimo = 0;
        }

        public void Inserir(Arquivo a)
        {
            if(((ultimo+1) % array.Length) == primeiro) { throw new Exception("Erro!"); }

            array[ultimo] = a;
            ultimo = (ultimo + 1) % array.Length;

        }

        public string Remover()
        {
            if(primeiro == ultimo) { throw new Exception("Erro!"); }

            string x = array[primeiro].Nome;
            primeiro = (primeiro + 1) % array.Length;
            return x;
        }

        public void Mostrar()
        {
            int i = primeiro;

            while(i != ultimo)
            {
                Console.WriteLine(array[i] + " ");
                i = (i + 1) % array.Length;
            }
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Fila filaImpressao = new Fila(100);
            int op, pg;
            string nome;
            do
            {
                Console.WriteLine("Op:");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        nome = Console.ReadLine();
                        pg = int.Parse(Console.ReadLine());
                        Arquivo a = new Arquivo(nome, pg);
                        filaImpressao.Inserir(a);
                        break;
                    case 2:
                        Console.WriteLine(filaImpressao.Remover());
                        break;
                    case 3:
                        filaImpressao.Mostrar();
                        break;
                    default:
                        break;
                }
            }
            while (op != 4);

        }
    }
}
