namespace Shop;

[Serializable]
public class Customer{
    public int Cid{get;set;}
    public string Name{get;set;}
    public string Email{get;set;}
    public string Password{get;set;}

public Customer(){
    
}
    public Customer( int cid, string name,string email, string password)
    {
        this.Cid = cid;
        Name = name;
        Email = email;
        Password = password;
    }

    public override string ToString()
    {
        return "Cid="+Cid+" "+"Name="+Name+" "+"email="+Email+" "+"password="+Password;
    }
}
