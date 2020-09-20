using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 7, 1, 2, 10, 4, 8, 6 };
          
            int temp = 0;

          

            for(int i=0;i<arr.Length; i++)
            {
                for(int j = i + 1;j < arr.Length; j++)
                {
                    if(arr[i]<arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
                Console.WriteLine(arr[i]);
                
            }
            Console.ReadLine();
        }
    }
}
