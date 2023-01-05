using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfConditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = 19;
            if(hour >= 0 && hour <= 12)
            {
                Console.WriteLine("It is morning.");
            }
            else if(hour >= 12 && hour <= 18)
            {
                Console.WriteLine("It is afternoon.");
            }
            else
            {
                Console.WriteLine("It is evening.");
            }
            Console.ReadLine();
        }
    }
}
