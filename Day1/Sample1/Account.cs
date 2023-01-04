namespace Banking;

public class Account{
    private double balance=8000;

    public Account(int balance){
        this.balance=balance;
    }

    public void withdraw(double amount){
        if(amount==0)
        {
            throw new Exception("Amount can not be zero");
        }

        this.balance= this.balance-amount;
    }

    public void Deposit(double amount)
    {
        this.balance += amount;
    }

    public double BalanceAmount{
        get{return this.balance;}
        set{this.balance=value;}
    }


    ~Account()
    {

    }

}