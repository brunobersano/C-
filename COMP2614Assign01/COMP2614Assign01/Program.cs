using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign01
{
    class Program
    {

        static void Main(string[] args)
        {
            double startNumber = 0; //select where would you like your number sequence to start
            double increment = 2; //select how much would you like the sequence to increment
            double endNumber = 20; //select how many times would you like number to be incremented
                 
            //The following variables will store the sum for the number, square and cube columns
            double sumNumber = 0;
            double sumSquare = 0;
            double sumCube = 0;

            //Diplay Header
            Console.WriteLine("{0, 5} {1, 10} {2, 10}", "number", "square", "cube");
            Console.WriteLine("----------------------------");

            //Displays numbers
            while (startNumber <= endNumber)
            {
                Console.WriteLine("{0, 5:N0} {1, 10:N0} {2, 10:N0}", startNumber, Math.Pow(startNumber, 2), Math.Pow(startNumber, 3));
                sumNumber = sumNumber + startNumber;
                sumSquare = sumSquare + (Math.Pow(startNumber, 2));
                sumCube = sumCube + Math.Pow(startNumber, 3);
                startNumber = startNumber + increment;
            }

            //Display Sums
            Console.WriteLine("----------------------------");
            Console.WriteLine("{0, 5:N0} {1, 10:N0} {2, 10:N0}", sumNumber, sumSquare, sumCube);





        }
    }
}
