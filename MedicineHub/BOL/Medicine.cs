namespace BOL;

public class Medicine
{
    public string Brand{get; set;}
    public string Name{get; set;}
    public string Id{get; set;}
    public string Generic{get; set;}
    
    public Medicine(string brand, string name, string id, string generic)
    {
        this.Brand=brand;
        Name=name;
        Id=id;
        Generic=generic;
    }

    public override string ToString()
    {
        return base.ToString()+"Brand: "+Brand+"Name: "+Name+"Id: "+Id+"GenericName: "+Generic;
    }
}
