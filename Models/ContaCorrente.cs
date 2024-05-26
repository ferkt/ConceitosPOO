using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numberAccount, decimal initialBalance)
        {
            NumberAccount = numberAccount;
            Balance = initialBalance;
        }

        public int NumberAccount { get; set; }
        private decimal Balance;

        public void Withdraw(decimal valor)
        {
            if (valor > Balance)
            {
                Console.WriteLine("Insufficient funds."); //Saldo insuficiente.
            }
            else 
            {
                Balance -= valor;
                Console.WriteLine("Withdrawal made successfully."); //Saque realizado com sucesso.
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}