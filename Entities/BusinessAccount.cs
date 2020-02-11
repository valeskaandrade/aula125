
namespace Aula125Heranca.Entities
{
    class BusinessAccount : Account //BusinessAccount extende Account
    {
        public double LoanLimit { get; set; } //limite de empréstimo
        public void Loan(double amount) //empréstimo
        {
            if (amount <= LoanLimit)
            { 
                Balance += amount;
            }
        }
        public BusinessAccount() 
        { 
        }

        public BusinessAccount(int number, string holder, double balance,double loanLimit) 
            : base (number,holder, balance)
        {
            LoanLimit = loanLimit;
        }
    }
}
