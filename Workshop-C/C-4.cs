using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_C
{
    class C_4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter The Distance");
            double dist = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
            if (dist==0 && dist==0.5)
            {
                Console.WriteLine("2.4");
            }
            else if(dist<=8.5)
            {
                Console.WriteLine(2.40+85*0.04);
            }
            else if (dist>=9)
            {
                Console.WriteLine(2.40 + 85 * 0.04+(122-90)*0.005);
            }
        }
    }
}
