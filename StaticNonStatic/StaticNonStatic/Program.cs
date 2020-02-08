using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticNonStatic
{
    class Circle
    {
        public float _pi = 3.141f;
        int r;

        public Circle(int radius)
        {
            r = radius;
        }
        public float Area()
        {
            return (_pi*(r * r));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            float area;
            int rad;
            for (int k = 0; k < 1; k++)
            {
                Console.WriteLine("Enter the radius:");
                rad = Convert.ToInt32(Console.ReadLine());
                Circle obj = new Circle(rad);
                area = obj.Area();
                Console.WriteLine("the area is " + area);
                Console.ReadLine();
                k--;
            }
        }
    }
}
