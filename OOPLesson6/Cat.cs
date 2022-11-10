using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson6
{
    internal class Cat : Animal
    {
        public string Color { get; set; }

        public Cat(string name, string sounds, string color)
            : base(name, sounds)
        {
            Color = color;

        }

        public override string Print()
        {
            return base.Print() + " " + Color;
        }

    }
}
