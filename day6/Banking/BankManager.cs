namespace Banking;
public delegate void AllowanceOperation(double amount);
public class BankManager{

    public void ClosedAccount(double amount)
    {
    Console.WriteLine("Due to less balance account as been Suspended");
    }

    public void SendEmail (double amount)
    {
    Console.WriteLine("Send Email...");
    }

    
    public void sendMesg (double amount)
    {
    Console.WriteLine("Send mesg...");
    }

}