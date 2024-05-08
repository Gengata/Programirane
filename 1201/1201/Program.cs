using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1201
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kolko ora che vuvejdah");
            int ora = int.Parse(Console.ReadLine());


            string[] imena = new string[ora];
            double[] gzobni = new double[ora];
            for (int i = 0; i < ora; i++)
            {
                Console.WriteLine("vuvedi ime za 4ovek", imena);
                imena[i] = Console.ReadLine();
                Console.WriteLine("vuvedi kolko jobni ima", imena, gzobni);
                gzobni[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < ora; i++)
            {
                Console.WriteLine(imena[ora] + "i ma " + gzobni[ora] + " leva ");

            }
            { 
            }          //izhod 2 btw
            Console.WriteLine("orata s gjobni nad 7lv ");
            for (int i =0; i < ora; i++)
            {
                if (gzobni[i] >= 7)
                Console.WriteLine(imena[ora] + " ima " + gzobni[ora] + "leva");
            }
            for (int i = 0; i < ora; i++)
            {
                Console.WriteLine(imena[ora] +" ima " + (gzobni[ora] -2));
            }

                }
    }
}
