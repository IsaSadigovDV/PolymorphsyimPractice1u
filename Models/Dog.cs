using PolymorphsyimGiris.Models.MainBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsyimGiris.Models
{
    internal class Dog:Animal
    {
        public Dog(string name) : base(name)
        {

        }

        public override void Speak()
        {
            Console.WriteLine(GetName() + " is hawking...");
        }
    }
}
