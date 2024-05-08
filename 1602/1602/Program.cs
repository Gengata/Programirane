using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1402
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string[] ime = new string[n];
            string[] imena;
            //i sega vhod
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("vuvedi ime:");
                ime[i] = Console.ReadLine();
                imena = Console.ReadLine().Split(' ').ToArray();
               
                Console.WriteLine(" purvo IME[{0}] = {1}", i, imena[i]);
                Console.WriteLine("vtoro IME[{0}] = {1}", i + 1, imena[i + 1]);
                Console.WriteLine("treto IME[{0}] = {1}", i + 2, imena[i + 2]);
            }

            // izhod 2 na elementi ot posledniq do purviq
            for (int i = n - 1; i >= 0; i--)
            {
                imena = Console.ReadLine().Split(' ');
                Console.WriteLine("IME[{0}] = {1}", i, imena[i]);
                Console.WriteLine("IME[{0}] = {1}", i, ime[i]);
                Console.WriteLine("IME[{0}] = {1}", i, ime[i]);
            }
            // izhod 3 
            for (int i = n - 1; i >= 0; i--)
            {
                imena = Console.ReadLine().Split(' ');
                Console.WriteLine("IME[{0}] = {1}", i , imena[i]);
                Console.WriteLine("IME[{0}] = {1}", i + 2, ime[i]);
                Console.WriteLine("IME[{0}] = {1}", i + 3, ime[i]);
            }





        }
    }
}