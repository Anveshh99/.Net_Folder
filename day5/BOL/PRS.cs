namespace BOL;
using System.Collections.Generic;
 
[Serializable]
public class PRS
{
    public int Empid{get;set;}

    public string Empname{get;set;}
    public string Designation{get;set;}
    public double Salary{get;set;}
    public double NetSalary{get;set;}

    public PRS()
    {
        Empid=0;
        Empname="XYZ";
        Designation="Developer";
        Salary=0;
        NetSalary=0;
    }



    public PRS(int Empid,string Empname,string Designation,double Salary)
    {
        this.Empid=Empid;
        this.Empname=Empname;
        this.Designation=Designation;
        this.Salary=Salary;
        this.NetSalary=netSalary(Salary);
    }

    public PRS(int empid)
    {
        Empid=empid;
    }

   

    public double netSalary(double Salary)
    {
        return Salary+0.20*Salary;
    }

    public override string ToString()
    {
        return "Empid: "+Empid+" Emp-Name"+Empname+" Post: "+Designation+" Salary"+Salary+" NetSalary"+NetSalary;
    }
    
    // public string this[int index]{
    //     get{return list[index];}
    //     set{list[index]=value;}
    // }





}
