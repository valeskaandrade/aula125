using System;
using Aula125Heranca.Entities;
using System.Globalization;

namespace Aula125Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna",500.00, 0.01);
            acc1.WithDraw(10);
            acc2.WithDraw(10);
            Console.WriteLine("Acc1 - saldo: " + acc1.Balance  );
            Console.WriteLine("Acc2- saldo: " +  acc2.Balance);
        }
    }
}

