using System.Diagnostics;
using Solid._02_OCP.Good;
using Solid._03_LSP.Good;

Discount healthDiscount = new HealthDiscount();
Console.WriteLine($"Health: {healthDiscount.Calculate(100)}");

// Primeiro declara a variável healthDiscount do tipo Discount. Até o momento ela não instancia nenhum objeto. Após isso, eu instancio a classe HealthDiscount, usando o operador NEW.

BankAccount account;
account = new SavingsAccount();