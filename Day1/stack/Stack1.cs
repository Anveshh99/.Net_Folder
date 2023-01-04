
class Stack{

    private int top;

    private int[] ArrayOfNumber;

    public Stack(int size)
    {
        top=-1;
        ArrayOfNumber=new int[size];
    }

    public bool isFull()
    {
        return top==ArrayOfNumber.Length;
    }

    public bool isEmpty()
    {
        return top==-1;
    }

    public bool push(int number)
    {
        if(top==-1)
        {
            ++top;
        }
        ArrayOfNumber[top++]=number;
        return true;
    }

    public void pop()
    {
        top--;
    }

    public void display()
    {
        for(int i=top-1; i<=0; i--)
        {
            Console.Write(ArrayOfNumber[top]+" ");
        }
        Console.WriteLine();
    }
 

}