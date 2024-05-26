using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Student : Person // Aluno herda Pessoa
    {
        public Student() // faz com que o Name seja opcional na hora instancia do objeto
        {
            
        }

        public Student(string name) : base(name) // como se estivesse chamando o constructor da classe Pai
        {
            
        }

        public double Grade { get; set; } //Nota

        public override void ToPresent()
        {
            Console.WriteLine($"Hi, my name is {Name}, I'm {Age} years old and I'm a straight 10 student.");
        }

        public void ShowGrade()
        {
            Console.WriteLine($"Grade: {Grade}");
        }
    }
}