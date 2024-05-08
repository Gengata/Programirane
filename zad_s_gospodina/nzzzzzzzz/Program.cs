using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nzzzzzzzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] chisla = new int[n];
            int sum = 0;
            for (int i = 0; i <n;i++)
            {
                Console.WriteLine("vuvedi chislo");
                chisla[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0;i <= chisla.Length - 1; i++)
            {
                sum += i * chisla[i];
            }
            Console.WriteLine("sum is {0}",sum);
        }  
    }
}
