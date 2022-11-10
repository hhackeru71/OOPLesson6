using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson6
{
    internal class Dog : Animal
    {
        public int Age { get; set; }
        public Dog(int age , string name,string Sounds)
            : base(name, Sounds)
        {
            Age = age;
        }

        public override string Print()
        {
            return base.Print() + " " + Age;
        }

    }

}
