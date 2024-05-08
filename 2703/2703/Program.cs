using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2703
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedi teks:");
            string str2 = Console.ReadLine();
            for (int i= str2.Length - 1;i>=0;i--)
            {

                Console.WriteLine(str2[i]);    
            }
            
        }
    }
}
