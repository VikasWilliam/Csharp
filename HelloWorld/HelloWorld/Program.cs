using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World,Its Vikas William.");
            Console.WriteLine("I will be a coder");
            //Console.ReadLine();
            // add two input nos;
            int a, b;
            int sum = 0;
            Console.WriteLine("Enter two nos");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            sum = a + b;
            Console.WriteLine("The sum is {0}", +sum);
            Console.ReadLine();
            
        }
    }
}
