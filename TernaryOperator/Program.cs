using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool isGoldCustomer = true;
            ////float price;

            ////if (isGoldCustomer)
            ////{
            ////    price = 20.45f;
            ////}
            ////else
            ////{
            ////    price = 25.87f;
            ////}
            //float price = (isGoldCustomer) ? 20.45f : 25.87f;
            //Console.WriteLine(price);

            Exercise1();
            Console.ReadLine();
            
        }

        public static void Exercise1()
        {
            Console.Write("Enter a number between 1 to 10: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
    }
}
