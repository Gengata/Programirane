using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadelane_na_pamet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zavejdane na pamet
            double[] pari = new double[2];
            string[] vid_zakuska = new string[2];
            //vhod
           
            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine("vuvedi zakuska");
                vid_zakuska[i] = Console.ReadLine();
                
                Console.Write("vuvedi pari");
                pari[i] = double.Parse(Console.ReadLine());
            }
            //izhod
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(vid_zakuska[i] + "/" + pari[i]);
            }
        }
    }
}
