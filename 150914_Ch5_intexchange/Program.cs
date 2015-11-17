using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _150914_Ch5_intexchange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first variable: ");
            int var1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second variable: ");
            int var2 = int.Parse(Console.ReadLine());

            if (var1 > var2)
            {
                int var3 = (var1 - var2);
                var2 = var2 + var3;
                var1 = var1 - var3;

            }

            Console.Write("First Variable: ");
            Console.WriteLine(var1);
            Console.Write("Second Variable: ");
            Console.Write(var2);
        
        }
    }
}
