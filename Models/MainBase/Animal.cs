using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsyimGiris.Models.MainBase
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            this.Name = name;
        }


        public string GetName()
        {
            return this.Name;
        }

        public string SetName(string name)
        {
           return this.Name = name;
        }

        public virtual void Speak()
        {
            Console.WriteLine("Animal is speaking...");
        }
    }
}
