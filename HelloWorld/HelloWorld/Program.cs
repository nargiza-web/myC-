using System;
using System.Dynamic;
using System.Linq;

namespace HelloWorld
{

    class Program
    {
        static void Main(string[] args)
        {
            // EXERCISE 1
            Console.WriteLine("Exercise1");
            Console.WriteLine("Enter number between 1-10");
            string userInt = Console.ReadLine();

            int result = Int32.Parse(userInt);

            if (result >= 0 && result <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }

            //EXERCISE 2
            Console.WriteLine("Exercise2");
            Console.WriteLine("Enter any two numbers following by enter");
            string userMin = Console.ReadLine();
            string userMax = Console.ReadLine();

            int result1 = Int32.Parse(userMin);
            int result2 = Int32.Parse(userMax);

            int[] array1 = { result1, result2 };

            Console.WriteLine(array1.Max());

            //EXERCISE 3
            Console.WriteLine("EXERCISE 3");
            Console.WriteLine("Enter the width and the height of your rectangle followed by enter");
            string width = Console.ReadLine();
            string height = Console.ReadLine();

            int width1 = Int32.Parse(width);
            int height1 = Int32.Parse(height);

            if( width1 > height1)
            {
                Console.WriteLine("landscape");
            }
            else
            {
                Console.WriteLine("portrait");
            }


            //EXERCISE 4
            Console.WriteLine("EXERCISE 4");
            Console.WriteLine("Enter the speed limit");
            string speed = Console.ReadLine();
            Console.WriteLine("Enter your speed");
            string yourSpeed = Console.ReadLine();

            int speed1 = Int32.Parse(speed);
            int yourSpeed1 = Int32.Parse(yourSpeed);

            if(yourSpeed1 <= speed1)
            {
                Console.WriteLine("OK");
            }
            else
            {
                int difference = yourSpeed1 - speed1;
                int div = difference / 5;
                if(div >= 12)
                {
                    Console.WriteLine("your license is suspended");
                }
                else
                {
                    String s = String.Format("your current point is {0}", div);
                    Console.WriteLine(s);
                }
            }

            
        }
    }
}
