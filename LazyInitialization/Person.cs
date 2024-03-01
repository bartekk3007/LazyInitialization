using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyInitialization
{
    internal class Person
    {
        public int Age {  get; set; }
        public Person(int age)
        {
            Age = age;
        }
        public override string ToString()
        {
            return $"I am {Age} years old";
        }
    }
}
