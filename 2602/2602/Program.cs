using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2602
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kolko pitieta che vuvejdah?");
            int n = int.Parse(Console.ReadLine());
           
            string[] pitie = new string[n]; 
            double[] cena = new double[n];
            int[] broi_pitieta = new int[n];
            for (int i = 0; i < n; i++)
            {
               
                Console.WriteLine("vuvedi pitivo");
                pitie[i] = Console.ReadLine();
                Console.WriteLine("vuvedi cena");
                cena[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("vuvedi broi pitiva");
                broi_pitieta[i] = int.Parse(Console.ReadLine());


            }
            Console.WriteLine("izhod 1");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(pitie[i] + "/" + cena[i] + "lv" +"/" + broi_pitieta[i]);
            }
            Console.WriteLine("izhod 2");
            for (int i = 0; i < n; i++)
            {
                if (broi_pitieta[i] < 2.5)
              Console.WriteLine(pitie[i] + "/" + cena[i] + "lv" + "/" + broi_pitieta[i]);

            }
            Console.WriteLine("izhod 3");
            for (int i = 0; i < n; i++)
            {
                if (cena[i] == 2 && pitie[i] == "kafe")
               Console.WriteLine(pitie[i] + "/" + cena[i] + "lv" + "/" + broi_pitieta[i]);

            }
            Console.WriteLine("izhod 4");
            Array.Sort(pitie);
            for (int i = 0; i < n; i++)
            {
             Console.WriteLine(pitie[i] + "/" + cena[i] + "lv" + "/" + broi_pitieta[i]);
            }
                Console.WriteLine("izhod 6");
            int FirstValue = 0;
            int midvalue = pitie.Length / 2;
           
                
          
                int LastValue = pitie.Length - 1;

                { Console.WriteLine(pitie[FirstValue] + "/" + pitie[midvalue] + "/" + pitie[LastValue]); }   

            Console.WriteLine("izhod 7");
            for (int i = 0; i < n; i++)
            {
                if (pitie[i] == "kafe")
                {
                    Console.WriteLine("chai");
                }
            }
           
           
           

        }


    }
}
