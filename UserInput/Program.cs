using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    internal class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
        /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
        /// applications where values entered into input boxes need to be validated.)
        /// </summary>
        public static void Excercise1()
        {
            Console.WriteLine("Enter a number between 1 to 10:");
            var input = Console.ReadLine();
            var number= Convert.ToInt32(input);
            
            if(number >= 1 && number <= 10)
            { 
                Console.WriteLine("Number is valid");
            }
            else
            {
                Console.WriteLine("Number is Invalid");
            }
        }
        /// <summary>
        /// Write a program which takes two numbers from the console and displays the maximum of the two.
        /// </summary>
        public static void Excercise2()
        {
            Console.WriteLine("Enter first number:");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Greater number is : " + max);
        }

        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait.
        /// </summary>
        /// 
        public static void Excercise3()
        {
            Console.WriteLine("Enter the width od an image:");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the height of an image:");
            var height = Convert.ToInt32(Console.ReadLine());
            var landscape = "Landscape";
            var portrait = "Portrait";

            var orientation = (width > height) ? landscape : portrait;
            Console.WriteLine("Image is " + orientation);         


        }

        /// <summary>
        /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
        /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
        /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
        /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
        /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
        /// the console. If the number of demerit points is above 12, the program should display License Suspended.
        /// </summary>
        /// 

        public static void Excercise4()
        {
            Console.WriteLine("Enetr the speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the speed of car:");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("It is OK.");
            }
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritsPoint = (carSpeed - speedLimit) / kmPerDemeritPoint;
                if (demeritsPoint > 12)
                {
                    Console.WriteLine("Your lisecse is suspended.");

                }
                else
                {
                    Console.WriteLine("DemeritPoints:" + demeritsPoint);
                }

            }
        }
        static void Main(string[] args)
        {
            //Excercise1();
            //Excercise2();
            //Excercise3();
              Excercise4();
            Console.ReadLine();
        }
    }
}
