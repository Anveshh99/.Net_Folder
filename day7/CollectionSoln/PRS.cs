namespace Organization;
using System.Linq;

public class PRS{
    public int Empid{get;set;}
    public string Empname{get;set;}
    public string Designation{get;set;}
    public double Salary{get;set;}


    public PRS()
    {
        Empid=0;
        Empname="XYZ";
        Designation="Developer";
        Salary=0;
    }

    public PRS(int Empid,string Empname,string Designation,double Salary)
    {
        this.Empid=Empid;
        this.Empname=Empname;
        this.Designation=Designation;
        this.Salary=Salary;
    }

    public override bool Equals(object? obj)
    {
        if(obj==null) return false;
        PRS objAsPRS = obj as PRS;
        if(objAsPRS == null) return false;
        else return Equals(objAsPRS);
    }

    public override int GetHashCode()
    {
        return Empid;
    }

    public override string ToString()
    {
        return Empname+" "+Empid+" "+Designation+" "+Salary;
    }

    public static IEnumerable<PRS>? GetEmployeeName(List<PRS> list)
    {
          var EmployeeByName = from p in list
                               where p.Empname.Contains('a')
                               select p;

          return EmployeeByName as IEnumerable<PRS>; 
    }

    public static IEnumerable<PRS>? GetEmployeeBySalary(List<PRS> list)
    {
          var EmployeeBySalary = from p in list
                               where p.Salary>70000
                               select p;

          return EmployeeBySalary as IEnumerable<PRS>; 
    }




}
