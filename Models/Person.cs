using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Person
    {
        public Person() // faz com que o Name seja opcional na hora instancia do objeto
        {
            
        }

        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public virtual void ToPresent() // virtual, permite o método ser sobrescrito por alguma classe filha
        {
            Console.WriteLine($"My name is {Name} and I'm {Age} years old");
        }
    }
}