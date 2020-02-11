

namespace Aula125Heranca.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; } // taxa de juros
        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance,double interestRate) 
            : base (number,holder,balance) 
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance() //Atualizar saldo
        {
            Balance += Balance * InterestRate;
        }
        public override void WithDraw(double amount)
        {
            base.WithDraw(amount);
            Balance -= 2.0 ;
        } //saque
    }
}
