using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9_1.Student
{
    internal class Student : Person
    {
        private double _gpa;
        public double Gpa 
        { 
            get => _gpa;  
            set 
            {
                if (value <= 0 || value >= 4)
                {
                    Console.WriteLine("GPA must be greater than 0 and smaller than 4");
                    _gpa = 0;
                }
                else
                {
                    _gpa = value;
                }
            } 
        }

        public Student()
        {
        }

        public Student(int age, string name, double gpa) : base(age, name)
        {
            _gpa = gpa;
        }

        public new void Input() 
        {
            Console.Write("Enter GPA: ");
            Gpa = double.Parse(Console.ReadLine());
            base.Input();
        }

        public void DisplayStudent()
        {
            Console.WriteLine($"This is {Name}, {Age} years old who have GPA: {_gpa}");
        }
    }
}
