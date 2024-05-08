using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAcc acc = new BankAcc();    
            var acc1 = new BankAcc();

            //acc.Id = 1;
            //acc.Deposit(20);
            //acc.Withdraw(30);
            //Console.WriteLine(acc.ToString());  



            var accounds = new Dictionary<int, BankAcc>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
               
                
             var cmdArgs = command.Split(' ');
                var id = int.Parse(cmdArgs[1]);
                if (accounds.ContainsKey(id)) { Console.WriteLine("Accounds alredy exist");}
                else
                {
                    var acc2 = new BankAcc();
                    acc.Id = id;    
                    accounds.Add(id, acc2); 
                }

               
                var cmdType = cmdArgs[0];
                switch (cmdType) 
                {
                    case "Create":Create(cmdArgs,accounds); break;
                    case "Deposit": Deposit(cmdArgs, accounds); break;
                    case "Withdraw":Withdraw(cmdArgs, accounds); break;
                    case "Print": Print(cmdArgs, accounds); break;
                }
            }
        }
    }
}
