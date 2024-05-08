using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1504
{
    internal class Program
    {
        static void Main(string[] args)
        {
            danni a = new danni();
            Console.WriteLine("kakva zakuska qde dnes?:");
            a.Ime = Console.ReadLine();
            Console.WriteLine("kolko qde?:");
            a.Broika = int.Parse(Console.ReadLine());
            Console.WriteLine("kolko pari imah?:");
            a.Pari = int.Parse(Console.ReadLine());
            Console.WriteLine("pil li si nesho dnes?:");
            a.Pitie = Console.ReadLine();

            a.izhod();

            if (a.Broika > 5) 
            {
                Console.WriteLine("parite sa ti po malko ot 5");
            }
            else
            {
                a.Pari = 5 * 5;
                Console.WriteLine(a.Pari);
                Console.WriteLine("parite sa ti poveche ot 5");
            }
            

          
            
            Console.WriteLine("pil li si nesho ");
            string da = Console.ReadLine();


            if (da == "da")
            {
                Console.WriteLine("Izberi 4ifra ot 0 do 3  ");
                int chisla = int.Parse(Console.ReadLine());    
                   switch (chisla)
            {
                case 0: Console.WriteLine("ti si pil martini");break;
                case 1:Console.WriteLine("ti si pil vodka"); break;

                case 2: Console.WriteLine("ti si pil voda"); break;
                case 3: Console.WriteLine("ti si pil whiskey"); break;
            }
            }
            else
            {
                Console.WriteLine("pil si ok");
                
            }
            a.Pitie = Console.ReadLine();
         
            Console.WriteLine(a.Broika);
        }
    }
}
