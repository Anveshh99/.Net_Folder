namespace EGovernance;

public delegate void TaxOperation(double amount);
public class CentralGovernment{

 public void DeductIncomeTax(double amount)
    {
    Console.WriteLine("45% income tax is deducted from your account");
    }
    public void DeductServiceTax(double amount)
    {
        Console.WriteLine("18% income tax is deducted from your account"); 
    }
    public void DeductProfessionalTax(double amount)
    {
        Console.WriteLine("10% income tax is deducted from your account");
    }

}