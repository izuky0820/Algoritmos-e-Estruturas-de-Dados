using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> playlist = new LinkedList<string>();
            int op;
            string music;
            do
            {
                Console.WriteLine("Op:");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        music = Console.ReadLine();
                        playlist.AddLast(music);
                        break;
                    case 2:
                        music = Console.ReadLine();
                        playlist.AddFirst(music);
                        break;
                    case 3:
                        string music2 = Console.ReadLine();
                        LinkedListNode<string> x = playlist.Find(music2);
                        music = Console.ReadLine();
                        playlist.AddAfter(x, music);
                        break;
                    case 4:
                        playlist.RemoveFirst();
                        break;
                    case 5:
                        playlist.RemoveLast();
                        break;
                    case 6:
                        music = Console.ReadLine();
                        playlist.Remove(music);
                        break;
                    case 7:
                        foreach(string i in playlist)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case 8:
                        music = Console.ReadLine();
                        if (playlist.Find(music) != null) { Console.WriteLine("sim"); }
                        else { Console.WriteLine("não"); }
                        break;
                    default:
                        break;

                }
            }
            while (op != 9);
        }
    }
}
