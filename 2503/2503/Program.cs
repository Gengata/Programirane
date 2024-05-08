using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2503
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] pitie = new string[n];
            double[] kolichestvo = new double[n];
            int[] broi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("vuvedi pitie");
                pitie[i] = Console.ReadLine();
                Console.WriteLine("vuvedi kolichestvo");
                kolichestvo[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("vuvedi broi");
                broi[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("ti pieh " + pitie[i] + " samo " + broi[i] + " broq ");
            }
            //for (int i = 0; i < n; i++)
            //{

            //        Console.WriteLine("Tvoite" + kolichestvo[i] + "litri sa" + kolichestvo[i]*1000 + "mililitri");
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    if (broi[i] > 2)
            //    {
            //        Console.WriteLine(broi);
            //    }

            //}
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (string.Compare(pitie[j], pitie[j + 1]) > 0)
                    {
                        string swapVar = pitie[j];
                        pitie[j] = pitie[j + 1];
                        pitie[j + 1] = swapVar;
                    }

                }
                Console.WriteLine(pitie);

            }
        }
    }
}          

