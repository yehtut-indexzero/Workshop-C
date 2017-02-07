using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_C
{
    class C_2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Gender");
            string Gender = Console.ReadLine();
            Console.WriteLine("Age");
            int age = Convert.ToInt16(Console.ReadLine());
            if (Gender.StartsWith("M"))
            {
                if (age>40)  { Console.WriteLine("Good Morning Uncle{0} ", name);}  else { Console.WriteLine("Good Morning Mr.{0} ", name); }                
            }
            else 
            {
                if (age > 40) { Console.WriteLine("Good Morning Aunty{0} ", name); } else { Console.WriteLine("Good Morning Ms.{0} ", name); }
            }
        }
    }
}
