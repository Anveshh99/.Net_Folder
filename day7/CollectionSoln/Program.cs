using Organization;

try
{
   List<PRS> list=new List<PRS>();
    
   list.Add(new PRS(101,"David","Developer",75000));
   list.Add(new PRS(102,"Jack","Developer",75000));
   list.Add(new PRS(103,"Ryan","Developer",55000));
   list.Add(new PRS(104,"Tim","Developer",85000));
   list.Add(new PRS(104,"Mac","Developer",70000));

   foreach (PRS item in list)
   {
    System.Console.WriteLine(item);
   }

   System.Console.WriteLine("*********************");
   list.Sort(new EmpComparer());

   foreach (PRS item in list)
   {
    System.Console.WriteLine(item);
   }

  var listOfA=PRS.GetEmployeeName(list);

   System.Console.WriteLine("*********************");

   foreach (var item in listOfA)
   {
    System.Console.WriteLine(item);
   }

   var listOfEmpSalary=PRS.GetEmployeeBySalary(list);

   System.Console.WriteLine("*********************");

   foreach (var item in listOfEmpSalary)
   {
    System.Console.WriteLine(item);
   }

   


}
catch (System.Exception)
{
    
    throw;
}
