using BOL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

try
{

        List<PRS> list=new List<PRS>();
    
        list.Add(new PRS(101,"David","Developer",75000));
        list.Add(new PRS(102,"Jack","Developer",75000));
        list.Add(new PRS(103,"Ryan","Developer",55000));
        list.Add(new PRS(104,"Tim","Developer",85000));
        list.Add(new PRS(104,"Mac","Developer",70000));

   
    bool exit=false;
    while (!exit)
    {
        System.Console.WriteLine("Please enter the choose:"
                                +"1. Display"
                                +"2. Serialized"
                                +"3. Serialized by method 2"
                                +"4. DeSerialized"
                                +"5. Update"
                                +"6. Delete"
                                +"7. GetbyId"
                                +"8. Exit");

       int ch=Convert.ToInt32(Console.ReadLine());

       
       switch (ch)
       {
        
        case 1:
        
        foreach(PRS p in list)
        {
        System.Console.WriteLine(p.ToString());
        }
        
        break;

        case 2:
        string fileName = "list.json"; 
        string jsonString = JsonSerializer.Serialize(list);
        File.WriteAllText(fileName, jsonString);
        Console.WriteLine(File.ReadAllText(fileName));
        break;

        case 3:
        var options=new JsonSerializerOptions {IncludeFields=true};
        var produtsJson=JsonSerializer.Serialize<List<PRS>>(list,options);
        string classfile=@"D:\DOT NET\Dot_Net_Practice\day5\products.json";
        File.WriteAllText(classfile,produtsJson);
        
        string jsonCollection=File.ReadAllText(classfile);
        List<PRS> jsonSalary=JsonSerializer.Deserialize<List<PRS>>(jsonCollection);
        System.Console.WriteLine("Deserialization started");
        foreach (PRS item in jsonSalary)
        {
            Console.WriteLine($"{item.Empid} : {item.Empname} : {item.Designation} : {item.Salary} : {item.NetSalary}");
            System.Console.WriteLine();
        }

        break;

        case 4:
        // list[2]="anvesh";
        
        //string classfile=@"D:\DOT NET\Dot_Net_Practice\day5\products.json";
       
        break;

        case 5:
        System.Console.WriteLine("enter the id to delete the record");
        //PRS temp=new PRS(Convert.ToInt32(Console.ReadLine));
        string input=Console.ReadLine();
        list.RemoveAt(Convert.ToInt32(input)-101);
        break;
     
        break;

        case 6:

        break;
     
        break;

        case 8: 
        exit=true;
        break;    
       }
    }

}
catch (System.Exception e)
{
    
    System.Console.WriteLine(e.StackTrace);
}


