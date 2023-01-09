namespace Organization;

class EmpComparer : IComparer<PRS>
{

    public int Compare(PRS x, PRS y)
    {
        if(x.Salary > y.Salary)
        {
            return 1;
        }
        else if(x.Salary < y.Salary)
        {
            return -1;
        }else
        return 0;
    }
}