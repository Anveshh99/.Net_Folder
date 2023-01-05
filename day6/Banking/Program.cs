using EGovernance;
using Banking;


CentralGovernment Govt=new CentralGovernment();
BankManager Bk=new BankManager();

TaxOperation itOperation=new TaxOperation(Govt.DeductIncomeTax);
TaxOperation proOperation=new TaxOperation(Govt.DeductProfessionalTax);

AllowanceOperation Accountsbalance=new AllowanceOperation(Bk.ClosedAccount);
AllowanceOperation mailOperation=new AllowanceOperation(Bk.SendEmail);
AllowanceOperation MesgOperation=new AllowanceOperation(Bk.sendMesg);

Account  acct123=new Account(6000);

acct123.overBalance+=itOperation;
acct123.overBalance+=proOperation;

acct123.underBalance+=mailOperation;
acct123.underBalance+=MesgOperation;

Console.WriteLine("Enter Amount to be deposited");
double amount=double.Parse(Console.ReadLine());
acct123.Deposit(amount);

Console.WriteLine("Before Tax processing");
Console.WriteLine(acct123);

//performing action
acct123.ProcessTax();
Console.WriteLine("After Tax processing");
Console.WriteLine(acct123);