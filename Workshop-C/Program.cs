using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Gender");
            string Gender = Console.ReadLine();
            if (Gender.StartsWith("M"))
            {
                Console.WriteLine("Good Morning Mr.{0}",name);
            }
            else
            {
                Console.WriteLine("Good Morning Ms.{0}", name);
            }
        }
    }
}
