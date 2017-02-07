using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_C
{
    class C_3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Marks");

            int marks = Convert.ToInt16(Console.ReadLine());

            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Not Valid");
            }
            else if (marks <= 0 || marks <= 40)
            {
                Console.WriteLine("F");
            }
            else if (marks == 40 || marks <= 59)
            {
                Console.WriteLine("C");
            }
            else if(marks==60 || marks<=79)
            {
                Console.WriteLine("B");
            }
            else if(marks==80 || marks<=100)
            {
                Console.WriteLine("A");
            }
        }
    }
}
