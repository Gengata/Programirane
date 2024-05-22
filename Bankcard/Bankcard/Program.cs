using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankcard
{
    internal class Program
    {
        internal class Adres
        {
            public static string Naseleno_mqsto {  get; set; }  
            public static string Ulica {  get; set; }   

        }

        static void Main(string[] args, BankCard bankCard, Nalicnost nalicnost)
        {
            Console.WriteLine("kolko danni che vuvejdah");
            int n = int.Parse(Console.ReadLine());
            string[] ime = new string[n];
            string[] familia = new string[n];
            int[] nomer = new int[n];
            double[] vkarani_pari = new double[n];
            double[] lixva = new double[n];
            double[] iztegleni = new double[n];
            string[] naseleno_mqsto = new string[n];
            string[] ulica = new string[n]; 
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Vuvedi adres");
                Adres.Naseleno_mqsto = Console.ReadLine();
                naseleno_mqsto[i] = Adres.Naseleno_mqsto;
                Console.WriteLine("Vuvedi ulica");
                Adres.Ulica = Console.ReadLine();
               ulica[i] = Adres.Ulica;

                Console.WriteLine("Vuvedi  ime");
                bankCard.ime = Console.ReadLine();
                ime[i] = bankCard.ime;
                Console.WriteLine("Vuvedi familia");
                bankCard.familia = Console.ReadLine();
                familia[i] = bankCard.familia;
                Console.WriteLine("Vuvedi  nomer");
                bankCard.nomer = int.Parse(Console.ReadLine());
                nomer[i] = bankCard.nomer;

                Console.WriteLine("Vuvedi  vkarani_pari");
                nalicnost.vkarani_pari = double.Parse(Console.ReadLine());  
                vkarani_pari[i] = nalicnost.vkarani_pari;
                Console.WriteLine("Vuvedi  lixva");
                nalicnost.lixva = double.Parse(Console.ReadLine());
                lixva[i] = nalicnost.lixva;
                Console.WriteLine("Vuvedi  izteglqne");
                nalicnost.iztegleni = double.Parse(Console.ReadLine());
                iztegleni[i] = nalicnost.iztegleni;

            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"naselenoto mqsto e {naseleno_mqsto[i]} imeto e {ime[i]} familia e {familia[i]}  nomer na kartata {nomer[i]} vkarani pari {vkarani_pari[i]} " +
                    $"lixvata e {vkarani_pari[i] % lixva[i]}");
            }

        }
    }
}
