class customer{
    public int custid;
    public string Name;
    public string Address;

    public customer(int id, string nm, string addr)
    {
        this.custid=id;
        this.Name=nm;
        this.Address=addr;
    }

    public void DisplayData()
    {
        Console.WriteLine("Customer :"+this.custid);
        Console.WriteLine("Name :"+this.Name);
        Console.WriteLine("Address :"+this.Address);
    }

    public override string ToString()
    {
        return "Customer Id"+this.custid;
    }
}