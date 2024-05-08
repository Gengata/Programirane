using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0804
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string str = "Hello, Genadi V C#";
            Console.WriteLine("vuvedi ime");
            string name = Console.ReadLine();
            Console.WriteLine("Hi" + name);
            Console.WriteLine("vuvedi bacheno ime");
            string lastNAME = Console.ReadLine();
            Console.WriteLine("Hi, " + lastNAME);
            Console.WriteLine("vuvedi familno ime");
            string familiNAME = Console.ReadLine();
            Console.WriteLine("Hi" + familiNAME);
            Console.WriteLine($"Hi {name}  { lastNAME} { familiNAME}");
            Console.WriteLine("result");
            int result = string.Compare(name, lastNAME, true);
            Console.WriteLine(result);
            string str1 = string.Concat(name, familiNAME);
            Console.WriteLine(str1);
            int firtsindex = str.IndexOf(",");
            Console.WriteLine(firtsindex);
            int vtoriindex =str.IndexOf("G",1);
            Console.WriteLine(vtoriindex);
            int notFound = str.IndexOf("/");
            Console.WriteLine(notFound);
            
            
            //string name1 = str.Substring(6,15);
            //Console.WriteLine(name1);

           
            string replace = str.Replace("V C#", "si otiva");
            Console.WriteLine(replace);

        }
    }
}
