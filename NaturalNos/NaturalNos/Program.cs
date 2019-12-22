using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalNos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int c = 0;
            Console.WriteLine("Enter the value of n for first n even nos");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The first " + n + " even nos are:");
            for(int i=1;i<=n;i++)
            {
                c = c + 2;
                Console.WriteLine(+c);
                
            }
            Console.ReadLine();
        }
    }
}
