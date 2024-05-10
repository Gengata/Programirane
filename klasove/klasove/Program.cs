using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasove
{
    internal class Program
    {
        static void Main(string[] args)
        { 
                
            Console.WriteLine("kak se kazvah");
            string name = Console.ReadLine();   
            
            ime ime = new ime();
            Console.WriteLine("zdraveite az sum " + name + " i sum mnogo qk");
        }
    }
}
