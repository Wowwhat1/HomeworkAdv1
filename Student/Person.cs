using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9_1.Student
{
    internal class Person
    {
        private int _age;
        public int Age
        {
            get => _age;
            set 
            {
                if (value < 0) Console.WriteLine("Invalid age!");
                else _age = value; 
            }
        }
        private string _name;
        public string Name { get => _name; set => _name = value; }

        public Person() 
        {
            _age = 0;
            _name= string.Empty;
        }

        public Person(int age, string name)
        {
            _age = age;
            _name = name;
        }

        public void Input() 
        {
            Console.Write("Enter age: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Enter name: ");
            Name = Console.ReadLine();
        }

        public void DisplayPerson()
        {
            Console.WriteLine($"This is {_name}, {_age} years olds.");
        }

        public override string? ToString()
        {
            return $"This is {_name}, {_age} years olds.";
        }
    }
}
