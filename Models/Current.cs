using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Current : Account // Herança
    {
        public override void Credit(decimal value) // Polimorfismo
        {
            Balance += value;
        }
    }
}