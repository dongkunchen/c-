using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] student = { 
                new Student("1001","張三",18,"101班"),
                new Student("1002","李四",19,"102班")
            };
            Student stu3 = new Student("1003", "王五", 20, "103班");

            

            List<Student> stuList = new List<Student>();
            stuList.Add(stu3);
            stuList.Add(new Student("1001", "張三", 18, "101班"));
            stuList.Add(new Student("1002", "李四", 19, "102班"));
            Student stu = stuList[0];
            Console.WriteLine(stu.StuName);            
            for (int i = 0; i < stuList.Count; i++)
            {
                Student s = stuList[i];
                Console.WriteLine(s.StuName);
            }
            Console.Read();
        }
    }
}
