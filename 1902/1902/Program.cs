using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1902
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vuvejdane
            int[] ime = new int[5];
            string[] nomer = new string[5];
            for (int i = 0; i <= 5; i++)
            {
                nomer[i] = Console.ReadLine();
                Console.WriteLine("vuvedi nomer");
                ime[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("ime");
            }

            //izhod
            for (int i = 0; i <= 5; i++)

            {
                Console.WriteLine(ime[i] + " " + nomer[i]);


            }
            for (int i = 0; i >= 3; i++)
            {
                if (i < 3)
                Console.WriteLine(nomer[i] + ime[i]);
            }
            Console.Write("kakvo ime che tursq");
            for (int i = 0; i <= 5; i++)
            {
                string name = Console.ReadLine();
                if (name == "ivan")
                  else
                        {

                        }
        }
             
}
}
