using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1303
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            for (int index = 0; index < list.Count;index++)
            {
                Console.WriteLine("list[{0}] = {1}", index, list[index]);
            }
            for (int i = 0; i < n; i++)
            {
                list.Remove(2);
                Console.WriteLine(String.Join(",", list));
            }
            for (int index = 0; index < list.Count; index++)
            {
                Console.WriteLine("list[{0}] = {1}", index, list[index]);
            }

            //int[] arr = new int[n];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("kolko 4isla che vuvejdah");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}



            //    for (int i = 0; i < arr.Length;i++)
            //{
            //    int swapVar = arr[i];
            //    int index = i;
            //    while (index > 0 && arr[index-1]>=swapVar)
            //    {
            //        arr[index] = arr[index-1];
            //        index--;

            //    }
            //    arr[index] = swapVar;
            //}
            //Console.WriteLine(string.Join(" ",arr));
        }
    }
}
