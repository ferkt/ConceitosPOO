using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public sealed class Teacher : Person
    {
        public Teacher() // faz com que o Name seja opcional na hora instancia do objeto
        {
            
        }

        public Teacher(string name) : base(name) // como se estivesse chamando o constructor da classe Pai
        {
            
        }

        public decimal Wage { get; set; } //Salário?

        public override void ToPresent() // override/sobrescreva
        {
            Console.WriteLine($"Hi, my name is {Name}, I'm {Age} years old and I earn a salary of {Wage}.");
        }
    }
}