﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1204
{
     internal class grupa
    {
        private string name;
        private string adres;
        private double grades;

        public String Name
        {
            get { return name; }
            set { name = value; }   
        }
        public double Grades
        {
            get { return grades;}   
            set { grades = value; }
        }
        public String Adres      
        {
            get { return adres; }
            set { adres = value; }
        }
        public void izhod()
        {
            Console.WriteLine($"Az sum {name} i ziveq na  {adres} i imam {grades}");
        }
        public void izhod1()
        {
            Console.WriteLine("Az sum {0} i ziveq na  {1} i imam {2}",name,adres,grades);
        }
        public void izhod2()
        {
            Console.WriteLine("Az sum " + name + "i ziveq na" + adres + "i imam" + grades);
        }


    }
}
