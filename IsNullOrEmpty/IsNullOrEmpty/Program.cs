using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNullOrEmpty
{

    class Program
    {
        static void Main(string[] args)
        {
            string S1 = "ABC";
            Program obj = new Program();
            obj.check(S1);

        }

        public void check(string s2)
        {
            if(!String.IsNullOrEmpty(s2))
            {
                Console.WriteLine("Null or empty");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not empty");
                Console.ReadLine();
            }
        }
    }
}
