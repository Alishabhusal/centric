using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"Before Swap: a = {a}, b = {b}");
            // Swap using XOR
            a = a ^ b; // Step 1: a becomes a XOR b
            b = a ^ b; // Step 2: b becomes the original a
            a = a ^ b; // Step 3: a becomes the original b

            Console.WriteLine($"After Swap: a = {a}, b = {b}");
        }
    }
}
