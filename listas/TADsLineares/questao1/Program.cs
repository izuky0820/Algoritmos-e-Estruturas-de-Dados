using System;

namespace questao1
{
    class Lista
    {
        double[] array;
        int n;

        public Lista(int tam)
        {
            array = new double[tam];
            n = 0;
        }

        public void InserirInicio(double x)
        {
            if (n >= array.Length)
                throw new Exception("Erro!");

            for (int i = n; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = x;
            n++;
        }

        public void InserirFim(double tempo)
        {
            if (n >= array.Length)
                throw new Exception("Erro!");

            array[n] = tempo;

            n++;
        }

        public void Inserir(double x, int pos)
        {
            if (n >= array.Length || pos < 0 || pos > n)
                throw new Exception("Erro!");

            for (int i = n; i > pos; i--)
            {
                array[i] = array[i - 1];
            }
            array[pos] = x;
            n++;
        }

        public double Remover(int pos)
        {
            if (n == 0 || pos < 0 || pos >= n)
                throw new Exception("Erro!");

            double resp = array[pos];
            n--;
            for (int i = pos; i < n; i++)
            {
                array[i] = array[i + 1];
            }
            return resp;

        }

        public void RemoverItem(double tempo)
        {
            if (n == 0)
                throw new Exception("Erro!");

            for (int i = 0; i < n; i++)
            {
                if (array[i] == tempo)
                {
                    Remover(i);
                    break;
                }
            }
        }

        public void RemoverInicio()
        {
            if (n == 0)
                throw new Exception("Erro!");
            double resp = array[0];
            n--;
            for (int i = 0; i < n; i++)
            {
                array[i] = array[i + 1];
            }
            Console.WriteLine(resp);
        }

        public void RemoverFim()
        {
            if (n == 0)
                throw new Exception("Erro!");
            n--;
            Console.WriteLine(array[n]);
        }

        public void Listar()
        {
           
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);

            }
        }

        public int Contar(double x)
        {
            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == x) { cont++; }

            }
            return cont;
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int op, pos;
            double tempo;
            Lista listaTempo = new Lista(100);
            do
            {
                Console.WriteLine("Op:");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        tempo = double.Parse(Console.ReadLine());
                        listaTempo.InserirInicio(tempo);
                        break;
                    case 2:
                        tempo = double.Parse(Console.ReadLine());
                        listaTempo.InserirFim(tempo);
                        break;
                    case 3:
                        tempo = double.Parse(Console.ReadLine());
                        pos = int.Parse(Console.ReadLine());
                        listaTempo.Inserir(tempo, pos);
                        break;
                    case 4:
                        listaTempo.RemoverInicio();
                        break;
                    case 5:
                        listaTempo.RemoverFim();
                        break;
                    case 6:
                        pos = int.Parse(Console.ReadLine());
                        Console.WriteLine(listaTempo.Remover(pos));
                        break;
                    case 7:
                        tempo = double.Parse(Console.ReadLine());
                        listaTempo.RemoverItem(tempo);
                        break;
                    case 8:
                        tempo = double.Parse(Console.ReadLine());
                        Console.WriteLine(listaTempo.Contar(tempo));
                        break;
                    case 9:
                        listaTempo.Listar();
                        break;
                    default:
                        break;
                }
            }
            while (op != 10);

        }
    }
}
