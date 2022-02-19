using System;
using System.Globalization;


namespace ContasBancariasPolimorfas.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() : base()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            Balance += amount;
        }

        public override void Withdraw(double amount)
        {

            //Console.WriteLine("0 EMPRESA " + Balance + " >= " + (amount + 2));

            if (Balance >= amount + 2)
            {
                base.Withdraw(amount + 2);
            }
        }



        public override string ToString()
        {
            return base.ToString() + ", Limite de Empréstimo : $"
                + LoanLimit .ToString("F2", CultureInfo.InvariantCulture)
                ;
        }


    }
}

