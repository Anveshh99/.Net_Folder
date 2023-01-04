using HR;
using Bank;

Person prn =Person.CreateInstance();

prn.Name="Anvesh";
prn.Id=12345;

System.Console.WriteLine(prn);

Person p=Person.CreateInstance();
System.Console.WriteLine(p);

Account acc=new Account();
// acc.Display();
int num=acc[3];
Console.WriteLine("Title: "+num);

Account account=(Account)acc.Clone();

System.Console.WriteLine(account[0]);

System.Console.WriteLine(account[1]);

System.Console.WriteLine(account[2]);

System.Console.WriteLine(account[3]);





