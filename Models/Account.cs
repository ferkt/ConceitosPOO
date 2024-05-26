using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Account // abstract -> não consigo instanciar, ela apenas pode ser herdada
    {
        protected decimal Balance; // protected -> como um private mas permite que as classes filhas possam alterar o valor do saldo

        public abstract void Credit(decimal value);

        public void ShowBalance()
        {
            Console.WriteLine($"Your balance is: {Balance}");
        }
    }
}