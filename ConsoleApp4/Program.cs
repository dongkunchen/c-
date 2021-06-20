using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            //int price1 = 100;

            //double price2 = price1;

            //int price3 = (int)price2;
            Console.Write("請輸入學生的年齡:");
            //第一種
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine(age);

            //第二種
            //int age;
            //bool result = int.TryParse(Console.ReadLine(), out age);

            //if (result)
            //{
            //    Console.WriteLine(age);
            //}
            //else
            //{
            //    Console.WriteLine("輸入格式不正確");
            //}
            //

            //第三種
            string str = "123";
            int money = Convert.ToInt32(str);
            Console.WriteLine(money);
            Console.Read();
        }
    }
}
