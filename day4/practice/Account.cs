namespace Bank;

public class Account:IDisposable {
    private int[] Ids;
    public Account() {
       Ids=new int[5];

       this.Ids[0]=101;
       this.Ids[1]=102;
       this.Ids[2]=103;
       this.Ids[3]=104;
       this.Ids[4]=105;

    }

    public int this[int index] {
        get{return this.Ids[index];}
        set{this.Ids[index] = value;}
    }

    public void Display(int[] ids)
    {
        foreach(int i in ids)
            Console.WriteLine(i);
    }

    ~Account() {
        System.Console.WriteLine("In Destructor");
    }

    public void Dispose()
    {
        System.Console.WriteLine("In DIspose()");
        GC.SuppressFinalize(this);
    }

    internal void Display()
    {
        throw new NotImplementedException();
    }

    public object Clone(){
        Account replica =new Account();
        this.Ids.CopyTo(replica.Ids,0);
        System.Console.WriteLine("Clonning done");
        return replica;
    }
}