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
        public string UserName { get; set; }

        public Animal(string name,string userName)
        {
            UserName = userName;
            Name = name;
        }

        public virtual string Get ()
        {
            return Name +" " + UserName;
        }
    }
}
