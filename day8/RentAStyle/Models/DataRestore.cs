namespace DataAccessLayer;
using System;
using System.Text.Json;
using System.Text;
using bussinesslayer;
using Shop;

public static class DataRestore
{
      public static List<Customer> RestoreData()
      {
        var options=new JsonSerializerOptions {IncludeFields=true};
         string fileName=@"D:\DOT NET\Dot_Net_Practice\Net_Folder\day8\RentAStyle\style.json";
         var jsondata= File.ReadAllText(fileName);
         List<Customer> st=JsonSerializer.Deserialize<List<Customer>>(jsondata);
         return st;
         }
}


