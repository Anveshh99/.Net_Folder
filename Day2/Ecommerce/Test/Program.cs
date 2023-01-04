using MemberShip;
using HR;

// See https://aka.ms/new-console-template for more information


Console.WriteLine("*****************************");
Console.WriteLine("Enter your Email ID");
String email=Console.ReadLine();

Console.WriteLine("Enter the password");
string password=Console.ReadLine();

if(AuthManage.Validate(email,password))
{
    Console.WriteLine("welcome to Store");
    Employee emp=new SalesEmployee();
    emp.DoWork();
    Console.WriteLine(emp);
    float salary=emp.ComputePay();
    Console.WriteLine("Salary = "+salary);
}else{
    Console.WriteLine("Invalid");
}


Console.WriteLine("Thank you for visiting Transflower");