using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1504
{
    internal class danni
    {
        private string ime;
        private int broika;
        private int pari;
        private string pitie;
       
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public int Broika
        {
            get { return broika; }
            set { broika = value; }
        }
        public void izhod()
        {
            Console.WriteLine("ti dnes si izql " + broika + " i si ql " + ime);
        }
        public int Pari
        {
            get { return pari; }
            set { pari = value; }
        }
        public void izhod2()
        {
            Console.WriteLine("izhod 2");
        }
        public string Pitie
        {
            get { return pitie; }
            set { pitie = value; }
        }
        public void izhod3()
        {
            Console.WriteLine("izhod 3");
        }
        


    }
}
