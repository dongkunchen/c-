using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lamp lamp = new Lamp();
            //lamp.Open();
            //Console.Read();
            Juicer juicer = new Juicer();
            string result = juicer.Juicing("蘋果");
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
