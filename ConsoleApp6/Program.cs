using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            Student stu1 = new Student("1001", "張三", 15, "101班");
            Student stu2 = new Student("1001", "李四", 16, "102班");
            Student stu3 = new Student("1001", "王五", 17, "103班");
            ArrayList arrayList = new ArrayList() 
            { 
                stu1,stu2,stu3
            };

            //arrayList.Remove(); stu1 刪除
            //arrayList.RemoveAt(); 下標 刪除
                
            for (int i = 0; i < arrayList.Count; i++)
            {
                Student stu = (Student)arrayList[i];
                Console.WriteLine(stu.ClassName + stu.Name);
            }
            Console.Read();
        }

    }
}
