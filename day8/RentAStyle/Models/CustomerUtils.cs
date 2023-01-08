namespace Shop;
using bussinesslayer;
using DataAccessLayer;
using System.Collections.Generic;
using System.Text.Json;
public class CustomerUtils{
    // List<Customer> PopulateList= new List<Customer>();

    public static void PopulateArray()
    {
        List<Customer> PopulateList= new List<Customer>();
        PopulateList.Add(new Customer(101,"anvesh","anvesh@gmail.com","asdfgh12345"));
        PopulateList.Add(new Customer(102,"anvy","anvy@gmail.com","anvy@12345"));
        File.WriteAllText("style.json", JsonSerializer.Serialize(PopulateList));
    }
    
}

