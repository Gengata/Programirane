using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ora___2604
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("N=");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("kak se kazvah");   
                person.name = Console.ReadLine();
                Console.WriteLine("vuvedi godini");
                person.age = int.Parse(Console.ReadLine());
                Console.WriteLine("ot koi grad si");
                person.grad = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(person.name + person.age + person.grad);
               
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("kak se kazvah");
                person.name1 = Console.ReadLine();
                Console.WriteLine("vuvedi godini");
                person.age1 = int.Parse(Console.ReadLine());
                Console.WriteLine("ot koi grad si");
                person.grad1 = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(person.name1 + person.age1   + person.grad1);

            }
            for (int i = 0; i < n; i++)
            {
                if (person.grad == "Sopot")
                {
                    Console.WriteLine(person.name + person.age + person.grad);
                   
                }
                else
                {
                    Console.WriteLine("nqma takiv ot nacho selo");
                }
            }
        }
    }
}
