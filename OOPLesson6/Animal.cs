using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson6
{
    internal class Animal
    {
        public string Name { get; set; }
        public string Sounds { get; set; }
        public Animal(string name, string sounds)
        {
            Name = name;
            Sounds = sounds;
        }

        public virtual string Print ()
        {
            return Name +" " + Sounds;
        }
    }
}
