using System;


namespace Questao2
{
    class Produto
    {
        private string nome;
        private int quant;
        private double preco;

        public Produto(string nome, int quant, double preco)
        {
            this.nome = nome;
            this.quant = quant;
            this.preco = preco;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Quant
        {
            get { return quant; }
            set { quant = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public override String ToString()
        {
            return nome + " " + quant + " " + preco;
        }



    }

    class Lista
    {
        Produto[] array;
        int n;

        public Lista(int tam)
        {
            array = new Produto[tam];
            n = 0;
        }

        public void InserirFim(Produto p)
        {
            if (n >= array.Length)
                throw new Exception("Erro!");

            array[n] = p;

            n++;
        }

        public Produto Remover(int pos)
        {
            if (n == 0 || pos < 0 || pos >= n)
                throw new Exception("Erro!");

            Produto resp = array[pos];
            n--;
            for (int i = pos; i < n; i++)
            {
                array[i] = array[i + 1];
            }
            return resp;

        }



        public Produto RemoverItem(string nome)
        {
            if (n == 0)
                throw new Exception("Erro!");



            for (int i = 0; i < n; i++)
            {
                if (array[i].Nome == nome)
                {
                    return Remover(i);

                }

            }
            return null;


        }

        public void Listar()
        {
            if (n == 0)
                throw new Exception("Erro!");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);

            }
        }

        public bool Pesquisar(string nome)
        {
            for (int i = 0; i < n; i++)
            {
                if (array[i].Nome == nome) { return true; }

            }
            return false;
        }



    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Lista listaProdutos = new Lista(100);
            int op, quant;
            string nome;
            double preco;
            Produto p;

            do
            {
                Console.WriteLine("Op:");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        nome = Console.ReadLine();
                        quant = int.Parse(Console.ReadLine());
                        preco = double.Parse(Console.ReadLine());
                        p = new Produto(nome, quant, preco);

                        listaProdutos.InserirFim(p);
                        break;
                    case 2:
                        nome = Console.ReadLine();
                        p = listaProdutos.RemoverItem(nome);
                        if (p == null) { Console.WriteLine("produto não encontrado"); }
                        else { Console.WriteLine(p); }


                        break;
                    case 3:
                        listaProdutos.Listar();
                        break;
                    case 4:
                        nome = Console.ReadLine();
                        if (listaProdutos.Pesquisar(nome)) { Console.WriteLine("produto cadastrado"); }
                        else { Console.WriteLine("produto não cadastrado"); }
                        break;
                    case 5:
                        break;
                }
            }
            while (op != 5);

        }
    }
}
