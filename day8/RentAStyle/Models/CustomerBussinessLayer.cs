namespace bussinesslayer;
using Shop;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

public class CustomerBussinessLayer{

    List<Customer> CustList= new List<Customer>(DataAccessLayer.DataRestore.RestoreData());

    public bool InsertData(int cid,string name,string email,string password)
    {
        if(cid!=0 && name!=null && email!=null && password!=null)
        {
            CustList.Add(new Customer(cid,name,email,password));
            CustList.ForEach((cust)=>{System.Console.WriteLine(cust);});
            return true;
        }
        return false;
    }

    public void storedetail()
    {
        try
        {
            var options=new JsonSerializerOptions{IncludeFields=true};
            var jsondata=JsonSerializer.Serialize<List<Customer>>(CustList,options);
            string filename=@"D:\DOT NET\Dot_Net_Practice\Net_Folder\day8\RentAStyle\style.json";
            File.WriteAllText(filename,jsondata);
            System.Console.WriteLine("datastored");
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }

    public bool validate(string email,string password)
    {
        foreach(Customer c in CustList)
        {
        if(c.Email==email && c.Password==password)
        {
        return true;
        }
        }
        return false;
    }

    public List<Customer> getData()
    {
    Console.WriteLine("into Get Data Method");
    CustList.ForEach((st)=>{Console.WriteLine(st);});
    return CustList;
    }
    

}    