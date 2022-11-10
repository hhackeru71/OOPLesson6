using OOPLesson6;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal[] aArr = new Animal[3];
            aArr[0] = new Animal("yarin", "how");
            aArr[1] = new Cat("yarin", "how", "red");
            aArr[2] = new Dog(30, "sad", "sadasd");
            foreach(Animal animal in aArr)
            {
                Console.WriteLine(animal.Print());
            }

            //Animal animal = new Animal("yarin","sdf");
            //Console.WriteLine(animal.Get());//yarin sdf
            //Animal animal2 = new Dog(30, "yarin", "asdasd");
            //Console.WriteLine(animal2.Get());//
            //Animal animal3 = new SuperDog(30, "yarin", "asdasd", "how");
            //Console.WriteLine(animal3.Get());//30, "yarin", "asdasd", "how"

            //Dog dog = new Dog(30,"yarin","asdasd");
            //Console.WriteLine(dog.Get());

        }


    }
}
