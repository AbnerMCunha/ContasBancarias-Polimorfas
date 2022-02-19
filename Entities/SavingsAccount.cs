using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed ContasBancariasPolimorfas.Entities
{
    internal class SavingsAccount : Account
    {

        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
        }

        public override string ToString()
        {
            return base.ToString() + ", Taxa: " 
                + ( InterestRate * 100 ).ToString("F2" , CultureInfo.InvariantCulture )
                + " %";
        }

    }
}
