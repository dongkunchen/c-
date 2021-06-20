using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            Console.WriteLine($"交換前:{num1}-{num2}");
            Swap(ref num1, ref num2);
            Console.WriteLine($"交換後:{num1}-{num2}");
            Console.Read();
        }
        public static void Swap(ref int num1,ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}
