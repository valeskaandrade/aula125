
namespace Aula125Heranca.Entities
{
    class Account
    {
        public int Number { get; private set; } //só lê não altera
        public string Holder { get; private set; } //titular
        public double Balance { get; protected set; } //saldo , protected => só pode ser alterado dentro da classe ou em subclasse


        public virtual void WithDraw(double amount) 
        {
            Balance -= amount +5.00;
        } //saque
        public void Deposit(double amount) 
        {
            Balance += amount;
        } //depósito

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
    }
}
