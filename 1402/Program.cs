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

            for (int i = 0; i < n; i++)
            //i sega vhod
            {
                Console.WriteLine("vuvedi ime:");
                string[] imena = Console.ReadLine().Split(' ').ToArray();
                Console.WriteLine("IME[{0}] = {1}",i, imena[i]);
                Console.WriteLine("IME[{0}] = {1}", i+1, imena[i+1]);
                Console.WriteLine("IME[{0}] = {1}", i+2, imena[i+2]);
            } 
           

            
                  
            
            
            

        }
    }
}
