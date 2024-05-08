using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _24_04
{
    internal class Program
    {
        static void Main(string[] args)
        {


            BankAcc acc = new BankAcc();

            acc.Id = 1;
            Console.WriteLine("kolko che vkarah");

            acc.Deposit(0);
            Console.WriteLine("kolko che teglih");

            acc.Withdraw(0);
            Console.WriteLine(acc.ToString());


            //MethodInfo oldesmembermethod = typeof(Person).GetMethod("vzemi staroto brato");
            //MethodInfo AddMemberMethod = typeof(Person).GetMethod("dobavi member");
            //if (oldesmembermethod == null || AddMemberMethod == null)
            //{

            //}
            Person person = new Person();
            person.age = 0;
            person.name = "";
            Console.WriteLine("kolko hora che vuvejdah");
            int n = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("vuvedi ime");
                person.name = Console.ReadLine();
                Console.WriteLine("vuvedi godini");
                person.age = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(acc.ToString() + " Ime " + person.name + " godini " + person.age);
            string name2 = Console.ReadLine();
            int age2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("vuvedi ime");
                person.name2 = Console.ReadLine();
                Console.WriteLine("vuvedi godini");
                person. age2 = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(acc.ToString() + " Vtori 4ovek  Ime " + person.name2 + " godini " + person.age2);

        }
    }
}
