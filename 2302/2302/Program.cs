using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace _2302
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedi 3 elementa:");
            int n = int.Parse(Console.ReadLine());
            string[] predmet = new string[3];
            int[] cas = new int[3];
            for (int i = 0; i <n;i++)
            {
                Console.WriteLine("vuvedi predmet");
                predmet[i] = Console.ReadLine();
                Console.WriteLine("vuvedi cas");
                cas[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("izhod 1");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("predmet "+predmet[i] + " v " + cas[i] );
            }
            Console.WriteLine("izhod 2");
            for (int i = 0; i < n; i++)
            {
                if (cas[i] >=4)
                Console.WriteLine("predmet " + predmet[i] + " v " + cas[i]);
            }
            //izhod 3
            Console.WriteLine("izhod 3");
            Array.Sort(cas);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("predmet " + predmet[i] + " v " + cas[i]);
            }
            Console.WriteLine("izhod 4");
            Array.Sort(predmet);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("predmet " + predmet[i] + " v " + cas[i]);
            }

            Console.WriteLine("izhod 5");
            Array.Reverse(predmet);
            Array.Sort(predmet);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("predmet " + predmet[i] + " v " + cas[i]);
            }
            
            Console.WriteLine("izhod 6");
            string nov_predmet = "matematika";
            for (int i = 0; i < n; i++)
            {
                if (predmet[i] == nov_predmet)
                Console.WriteLine("predmet " + predmet[i] + " v " + cas[i]);
            }

            Console.WriteLine("izhod 7");
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("predmet " + predmet[i] + " v " + cas[i]);
            }

        }
    }
}
