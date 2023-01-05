using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Summer;
            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("It is a spring and beautiful season.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It is a holiday time.");
                    break;
               case Season.Winter:
                    Console.WriteLine("It is a snow time.");
                    break;
                default:
                    Console.WriteLine("It is a autumn season.");
                    break;
            }
            Console.ReadLine(); 
        }


    }
}
