using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Student
    {
        public Student() { }
        public Student(string classNo, string stuName, int age, string className) {
            this.ClassNo = classNo;
            this.StuName = stuName;
            this.Age = age;
            this.ClassName = className;
        }
        public string ClassNo;
        public string StuName;
        public int Age;
        public string ClassName;
       
    }
}
