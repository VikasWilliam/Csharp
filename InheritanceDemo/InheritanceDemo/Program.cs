using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        //public  Employee(string firstName,string lastName,string email)
        //{
        //    this.FirstName = firstName;
        //    this.LastName = lastName;
        //    this.Email = email;
        //}
        public void display()
        {
            Console.WriteLine("First Name is-" + FirstName);
            Console.WriteLine("Last name is-" + LastName);
            Console.WriteLine("Email is-" + Email);
            //Console.ReadLine();
        }
    }
   class A : Employee
    {
        public int Salary;

        public void show()
        {
            Console.WriteLine(Salary);
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            obj.FirstName = "vikas";
            obj.LastName = "William";
            obj.Email = "vikasdenobili@gmail.com";
            obj.Salary = 40000;
            obj.display();
           obj.show();

            
        }
    }
}
