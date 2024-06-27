using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=5,y=10, z;

            // Bitwise AND "&" Operator
            z = x & y;
            Console.WriteLine("Bitwise AND: " +z);

            // Bitwise OR "|" Operator
            z = x | y;
            Console.WriteLine("Bitwise OR: " + z);

            // Bitwise XOR  "^"Operator 
            z = x ^ y;
            Console.WriteLine("Bitwise XOR: " + z);

            // Bitwise Complement Operator
            z = ~x  ;
            Console.WriteLine("Bitwise Complement: " + z);

            // Bitwise Left Shift Operator

            z = x << y;
            Console.WriteLine("Bitwise Left Shift : " + z);

            // Bitwise Right Shift Operator
            z = x >> y;
            Console.WriteLine("Bitwise Right Shift: " + z);
            Console.ReadLine();
        }
    }
}
