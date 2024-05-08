using System;

namespace _1103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nomer = new int[] { 2, 4, -5, 1, 10 };
            string[] ime = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("nomer");
                nomer[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("ime");
                ime[i] = Console.ReadLine();
            }
            Console.WriteLine("normalen ishod");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("nomer " + nomer[i] + "ime " + ime[i]);
            }
            Console.WriteLine("sortirane po nomer");
            for (int j = 0; j < nomer.Length - 1; j++)
            {
                for (int i = 0; j < nomer.Length - 1; j++)
                {
                    if (nomer[j] > nomer[j + 1])
                    {
                        int swapVar = nomer[j];
                        nomer[j] = nomer[j + 1];
                        nomer[j + 1] = swapVar;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(nomer[i] + " ");
            }


            Console.WriteLine("sortirane po nomer wuzhodqc");
            for (int j = 0; j < n - 1; j++)
            {
                for (int i = 0; j < n - 1; j++)
                {
                    if (nomer[j] > nomer[j + 1])
                    {
                        int swapVar = nomer[j];
                        nomer[j] = nomer[j + 1];
                        nomer[j + 1] = swapVar;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(nomer[i] + " ");
            }

            Console.WriteLine("sortirane po imeeeeeeee");

            for (int i = 1; i < nomer.Length; i++)
            {


                int k = i;
                for (int j = i + 1; j < nomer.Length; j++)
                    
                {
                    if (nomer[j] < nomer[k])
                        k = j;
                }
                int swapVar = nomer[i];
                nomer[i] = nomer[k];
                nomer[k] = swapVar;   
            }
            Console.WriteLine(string.Join(" ", nomer));
            Console.WriteLine(string.Join(" ", ime));


        }

    }
}
