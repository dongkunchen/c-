using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dog
    {
        public string Name;

        public string Color;

        public bool Run()
        {
            Console.WriteLine($"{this.Color}的{this.Name}跑起來");
            bool result = true;
            return result;
        }
    }
}
