using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> horas = new List<double>();
            int op, pos;
            double h;

            do
            {
                Console.WriteLine("Op:");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        h = double.Parse(Console.ReadLine());
                        horas.Insert(0,h);
                        break;
                    case 2:
                        h = double.Parse(Console.ReadLine());
                        horas.Add(h);
                        break;
                    case 3:
                        h = double.Parse(Console.ReadLine());
                        pos = int.Parse(Console.ReadLine());
                        horas.Insert(pos, h);
                        break;
                    case 4:
                        Console.WriteLine(horas[0]);
                        horas.RemoveAt(0);
                        break;
                    case 5:
                        Console.WriteLine(horas[horas.Count-1]);
                        horas.RemoveAt(horas.Count - 1);
                        break;
                    case 6:
                        pos = int.Parse(Console.ReadLine());
                        Console.WriteLine(horas[pos]);
                        horas.RemoveAt(pos);
                        break;
                    case 7:
                        h = double.Parse(Console.ReadLine());
                        horas.Remove(h);
                        break;
                    case 8:
                        int cont = 0;
                        h = double.Parse(Console.ReadLine());
                        foreach(double i in horas)
                        {
                            if(i == h) { cont++; }
                        }
                        Console.WriteLine(cont);
                        break;
                    case 9:
                        foreach(double i in horas)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case 10:
                        horas.Sort();
                        foreach (double i in horas)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case 11:
                        horas.Sort();
                        horas.Reverse();
                        foreach (double i in horas)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    default:
                        break;

                }
            }
            while (op != 12);


        }
    }
}
