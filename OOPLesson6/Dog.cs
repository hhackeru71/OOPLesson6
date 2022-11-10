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
        public Dog(int age , string name,string userName)
            : base(name, userName)
        {
            Age = age;
        }

        public override string Get()
        {
            return base.Get() + " " + Age;
        }

    }

    class SuperDog :Dog
    {
     
        public string Sound { get; set; }
        public SuperDog(int age, string name, string userName, string sound)
            :base(age,name,userName)
            
        {
            Sound = sound;
        }

        public override string Get()
        {
            return base.Get() + " " + Sound;
        }

    }
}
