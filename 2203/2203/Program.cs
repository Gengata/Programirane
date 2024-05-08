using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of students:");
            int n = int.Parse(Console.ReadLine());
            string[] name = new string[n];
            double[] number = new double[n];
            string[] subject = new string[n];
            int[] grade = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter name[{i}]:");
                name[i] = Console.ReadLine();
                Console.Write($"Enter number[{i}]:");
                number[i] = int.Parse(Console.ReadLine());
                Console.Write($"Enter subject[{i}]:");
                subject[i] = Console.ReadLine();
                Console.Write($"Enter grade[{i}]:");
                grade[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("izhod 1");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{name[i]} с номер в класа #{number[i]} по предмет {subject[i]} има оценка {grade[i]}[{i}]");
            }
            Console.WriteLine("izhod 2");
            for (int i = 0; i < n; i++)
            {
                if (grade[i] >= 5.25)
                {
                    Console.WriteLine(grade[i] + " - " + name[i]);
                }


            }
            Console.WriteLine("izhod 3 ");
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-1; j++)
                {
                    if (grade[j] > grade[j +1])
                    {
                        int swapVar = grade[j];
                        grade[j] = grade[j + 1];
                        grade[j + 1] = swapVar;    
                    }

                }
            }
            Console.WriteLine(string.Join(" ", grade));
            Console.WriteLine("izhod 4 ");
            for (int i = 0; i < n - 1; i++)
            {
                if (name[i] == "Genadi")
                {
                    if (number[i] >= 5 && number[i] <= 10)
                    {
                        Console.WriteLine("ima Genadi s nomer "+ number[i]);
                    }
                    else
                    {
                        Console.WriteLine($"ima Genadi, no nomera mu ne e mejdu 5-10 ({number[i]})");
                    }
                }


            }
            Console.WriteLine("izhod 5 ");
            for (int i = 0; i < n - 1; i++)
                if (name[i] == name[i + 1])
                {
                    if (number[i] > number[i + 1])
                    {
                        double var = number[i];
                        number[i] = number[i + 1];
                        number[i + 1] = var;    
                    }
                }
            Console.WriteLine(string.Join(" ",number));
                

                Console.WriteLine("izhod 6 ");
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (string.Compare(subject[j] ,subject[j + 1]) > 0)
                    {
                        string swapVar = subject[j];
                        subject[j] = subject[j + 1];
                        subject[j + 1] = swapVar;
                    }

                }
                for (int k = 0; i < n - 1; i++)
                {
                    Console.WriteLine(subject[i]);
                }
                    
                
            }




        }
    }
}
