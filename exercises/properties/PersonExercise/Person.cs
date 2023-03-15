using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonExercise
{
    internal class Person
    {

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name may not be empty!");
                }
                this.name = value;
            }
        }

        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value <= 0) 
                {
                    throw new ArgumentException("Age must be strictly positive!");
                }
                this.age = value;
            }
        }

    }
}
