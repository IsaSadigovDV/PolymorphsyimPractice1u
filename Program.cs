using PolymorphsyimGiris.Models;
using PolymorphsyimGiris.Models.MainBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsyimGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("animal");
            animal.Speak();

            Cat cat = new Cat("Lili");
            cat.Speak();

            Dog dog = new Dog("Boss");
            dog.Speak();

            Console.ReadLine();

        }
    }
}
