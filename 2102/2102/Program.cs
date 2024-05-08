using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedi kolko 4isla che vuvejdah");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("kolko pari che zavurtvam");
            int k = int.Parse(Console.ReadLine());
            

            int[] number = new int[n];
            int[] sum = new int[n];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("vuvedi 4isla");
                number[i] = int.Parse(Console.ReadLine());
                //sum[i] = 0;
                
            }

            //ihhod 3
            Console.WriteLine("vuvedi cisla");
            for (int i = 0; i <4; i++)
            {
                Array.Reverse.Sort
                Array.Sort(number); 
            }
            Console.WriteLine("ihhod bez posleden element");










            //sum[n] = 0;
            //for (int r = 1; r < n;r++)
            //{

            //    for(int i = 0; i<n-1;i++)
            //    {
            //        sum[i] = sum[i] + r + i;
            //        sum[i] = sum[i] + r;
            //    }
            //}
            //Console.WriteLine(sum[n]);
            //for (int r = 1; r < n; r++)
            //{

        }



        }
    }

