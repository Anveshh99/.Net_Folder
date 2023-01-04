namespace HR;

public sealed class Person{
    public double PI;
    public int Id{get;set;}
    public string Name{get;set;}

    //step 1- Creating Singleton pattern

    public static Person _ref=null;


    private Person(){
        this.Name="Anvesh";
        this.Id=229012;
    }

    public static Person CreateInstance(){
        if(_ref==null)
        {
            _ref=new Person();
        }
        return _ref;
    }


    public override string ToString()
    {
        return "Name :"+Name+" Id: "+Id;
    }

}