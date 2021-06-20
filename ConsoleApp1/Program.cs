using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //實例化
            Dog dog1 = new Dog();
            dog1.Name = "旺財";
            dog1.Color = "黃色";
            bool result = dog1.Run();
            if (result)
            {
                Console.WriteLine("調用成功");
            }
            else
            {
                Console.WriteLine("調用失敗");
            }
            Console.Read();
        }
    }
}
