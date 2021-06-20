using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Student
    {
        public Student() { }
        public Student(string classNo, string name,int age,string className)
        {
            this.ClassNo = classNo;
            this.Name = name;
            this.Age = age;
            this.ClassName = className;
        }

        public string ClassNo;
        public string Name;
        public int Age;
        public string ClassName;
    }
}
