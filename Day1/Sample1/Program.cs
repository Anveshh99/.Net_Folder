// See https://aka.ms/new-console-template for more information

using Banking;

Account acc123=new Account(6000);
acc123.Deposit(5000);
double currentBalance123=acc123.BalanceAmount;
Console.WriteLine(acc123.BalanceAmount);

acc123.BalanceAmount=15000;
double currentBalance124=acc123.BalanceAmount;
Console.WriteLine(acc123.BalanceAmount);

acc123.withdraw(10000);
double currentBalance125=acc123.BalanceAmount;
Console.WriteLine(acc123.BalanceAmount);



