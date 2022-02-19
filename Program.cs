
using System;
using System.Globalization;
using ContasBancariasPolimorfas.Entities;

namespace ContasBancariasPolimorfas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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

            Console.WriteLine("\nSaque de $5 \n");


            Console.WriteLine("Conta Normal : $ " + account.Balance);
            Console.WriteLine("Conta Empresarial : $ " + businessAccount.Balance);
            Console.WriteLine("Conta Poupança : $ " + savingsAccount.Balance);

            
             * Resultado em Tela
             * 
                Balanço
                Conta Normal : $ 20
                Conta Empresarial : $ 20
                Conta Poupança : $ 20

                Saque de $5

                Conta Normal : $ 10
                Conta Empresarial : $ 8
                Conta Poupança : $ 15             
             */


            /* Conceito de Upcasting e Downcasting */

            Account account = new Account();

            BusinessAccount businessAccount = new BusinessAccount();
            SavingsAccount savingsAccount = new SavingsAccount();

            //Upcasting - Convertendo a Instanciação de SubClasses em Instancia da SuperClasse
            account = businessAccount;

            //Erro em tempo de execução somente
            //businessAccount = account;

            Account accountUpcasting1 = new Account(1000, "Normal", 500);
            Account accountUpcasting2 = new BusinessAccount(1001, "Empresarial", 500, 500);
            Account accountUpcasting3 = new SavingsAccount(1002, "Poupança", 500, 0.01);

            Console.WriteLine("Conta Normal Criada \nStatus " + accountUpcasting1);
            Console.WriteLine("\n\nConta Empresarial Criada como normal \nStatus " + accountUpcasting2);
            Console.WriteLine("\n\nConta Poupança Criada como normal \nStatus " + accountUpcasting3);

            Console.WriteLine(
                                    "\naccount.GetType : " + account.GetType() +
                                    "\nbusinessAccount.GetType : " + businessAccount.GetType() +
                                    "\nsavingsAccount.GetType : " + savingsAccount.GetType() +
                                    "\naccountUpcasting1.GetType : " + accountUpcasting1.GetType() +
                                    "\naccountUpcasting2.GetType : " + accountUpcasting2.GetType() +
                                    "\naccountUpcasting3.GetType : " + accountUpcasting3.GetType()

                );
            //Dowcasting - Convertendo a Instanciação de SuperClasse em Instancia da SubClasses

            //BusinessAccount DowncastingQueDaErro = (BusinessAccount)accountUpcasting3;
            //Jeito correto de executa Downcasting

            if (accountUpcasting3 is BusinessAccount)
            {
                //1º Forma de fazer Dowcasting (BusinessAccount)accountUpcasting3;
                BusinessAccount DowcastingCorreto = (BusinessAccount)accountUpcasting3;
                DowcastingCorreto.Loan(300);
                Console.WriteLine(

                    "\n--------------------------" +
                    "\nEmprestimo feito! \nBalanço : " + DowcastingCorreto.Balance.ToString());
            }

            if (accountUpcasting3 is SavingsAccount)
            {
                //2º Forma de fazer Dowcasting accountUpcasting3 as SavingsAccount;
                /*
                SavingsAccount DowcastingSavingsAccount = accountUpcasting3 as SavingsAccount;
                Console.WriteLine("\n--------------------------" +
                    "\naccountUpcasting3.GetType : " + accountUpcasting3.GetType() +
                    "\nDowcastingSavingsAccount.GetType : " + DowcastingSavingsAccount.GetType() +
                    "\nConta Normal foi transformada em Conta Poupança com Sucesso! \n");

                Console.WriteLine("\n" + DowcastingSavingsAccount);
                
                DowcastingSavingsAccount.UpdateBalance();
                */

                accountUpcasting3.UpdateBalance();
                Console.WriteLine("\nSaldo de Conta Poupança atualizado a uma taxa de " +
                    (DowcastingSavingsAccount.InterestRate * 100) +
                    "% ! \nStatus " + DowcastingSavingsAccount);
            }

            //                Resultado em Tela
            //            
            //                Balanço
            //                Conta Normal : $ 20
            //                Conta Empresarial : $ 20
            //                Conta Poupança : $ 20
            //
            //                Saque de $5
            //
            //                Conta Normal : $ 10
            //                Conta Empresarial : $ 8
            //                Conta Poupança : $ 15



        }
    }
}