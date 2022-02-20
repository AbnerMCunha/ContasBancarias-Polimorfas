# ContasBancarias-Polimorfas
Conceito de Herança e Polimorfismo - Palavras Virtual, Override e Base e Sealed

Herança é utilizada a partir da Superclasse Account, 
que é a Conta Bancaria Padrão com apenas: 
-Atributos  : Number (Numero da Conta) , Titular(Holder), Balance (Saldo)
-Metodos : WithDraw(Saque), Deposit(Deposito)

As SubClasses SavingsAccount(Conta Poupança) e BusinessAccount(Conta Empresarial) herdam todos os Atributos e Metodos de Account ao realizar o seguinte comando na Declaração
internal class BusinessAccount  : Account
internal class SavingsAccount   : Account
Com isso se Tornam Especializações de Accont que é Generalista

A SubClasse BusinessAccount acrescentou o Atributo LoanLimit (Limite de Empréstimo) e o Metodo Loan(Empréstimo)
A SubClasse SavingsAccount acrescentou o Atributo InterestRate (Taxa de Juros) e o Metodo UpdateBalance(Atualização de Saldo)

O Polimorfismo que representa o conceito de que, para diferentes casos, agir de formas diferentes
Esse conceito foi utilizado no Metodo WithDraw e ToString(), com ajuda das palavas Virtual, Override e Base
Virtual : Aplicavel a SuperClasse e define que as SubClasses Poderam ter comportamentos diferentes da SuperClasse
Override : Aplicavel as SubClasses e Definem que aquele metodo já existente na SuperClasse, terá um formato Diferente naquela SubClasse
Base.Metodo() : Aplicavel as SubClasses e Retorna o comportamento Padrão da Superclasse na SubClasse

A Palavra Sealed utilizadas na declaração de Classes e Metodos para que definir que não haverá Herança ou sobrepoisção daquela classe ou metodo, respectivamente.
Neste projeto é utilizada na SubClasse SavingsAccount.
