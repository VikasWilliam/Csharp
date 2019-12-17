using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            Console.WriteLine("Enter the value of n");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=n;i++)
            {
                for(int j=0;j<i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
