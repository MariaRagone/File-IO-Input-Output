using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_File_IO_Exercise
{
    internal class Student
    {
        //PROPERTIES
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        //CONSTRUCTOR
        public Student(string _name, int _age, int _grade)
        {
            Name = _name;
            Age = _age;
            Grade = _grade;
        }

        //METHODS
    }
}
