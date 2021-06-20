using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("1001", "張三", 18, "101班");
            Student stu2 = new Student("1002", "李四", 19, "102班");
            Student stu3 = new Student("1003", "王五", 20, "103班");
            Teacher t1 = new Teacher();
            Dictionary<string, Student> dict = new Dictionary<string, Student>();
            dict.Add("zs", stu1);
            dict.Add("ls", stu2);
            dict.Add("ww", stu3);

            Student stu = dict["ls"];
            Console.WriteLine(stu.StuName);



            Console.Read();
        }
    }
}
