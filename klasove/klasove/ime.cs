using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace klasove
{
    internal class ime
    {
        private string aut;
        private string name;
        public string Name
        {
            get { return name; }    
            set { name = value; }   
        }
        public void Aut()
        {
            Console.WriteLine("zdraveite az sum" + name + "i sum mnogo qk");  
            
        }
    }
}
