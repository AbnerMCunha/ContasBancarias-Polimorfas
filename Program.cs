
using System;
using System.Globalization;
using ContasBancariasPolimorfas.Entities;

namespace ContasBancariasPolimorfas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Account account = new Account(1000, "Norman", 20);
            BusinessAccount businessAccount = new BusinessAccount(1001, "Empresario", 20, 500);
            SavingsAccount savingsAccount= new SavingsAccount(1002, "Pupanca", 20, 0.01);

            Console.WriteLine("Balanço ");

            Console.WriteLine("Conta Normal : $ " + account.Balance);
            Console.WriteLine("Conta Empresarial : $ " + businessAccount.Balance);
            Console.WriteLine("Conta Poupança : $ " + savingsAccount.Balance);


            account.Withdraw(5);
            businessAccount.Withdraw(5);
            savingsAccount.Withdraw(5);

            Console.WriteLine("\nSaque de $5 das Contas \n");


            Console.WriteLine("Conta Normal : $ " + account.Balance);
            Console.WriteLine("Conta Empresarial : $ " + businessAccount.Balance);
            Console.WriteLine("Conta Poupança : $ " + savingsAccount.Balance);

            /*
             * Resultado em Tela
              
                Balanço
                Conta Normal : $ 20
                Conta Empresarial : $ 20
                Conta Poupança : $ 20

                Saque de $5

                Conta Normal : $ 10
                Conta Empresarial : $ 8
                Conta Poupança : $ 15             
                
                //Por conta dos conceitos de Herança e Polimorfismo 
                //Após um saque de mesma quantia, cada Classe se comportou de forma Diferente
                
            */

        }
    }
}
