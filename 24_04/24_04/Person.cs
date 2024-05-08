using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _24_04
{
    internal class Person
    {
        public int age;

        public string name;

        public int Age
        {
            get { return age; }
            set {age = value; } 
        }
        public string Name
        {
            get { return name; }
            set { name = value; }   
        }
        public int age2;

        public string name2;

        public int Age2
        {
            get { return age2; }
            set { age2 = value; }
        }
        public string Name2
        {
            get { return name2; }
            set { name2 = value; }
        }




    }
}
