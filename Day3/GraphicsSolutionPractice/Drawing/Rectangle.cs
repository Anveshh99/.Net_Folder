namespace Drawing;

public class Rectangle : Shape, IPrintable{
    public Point StartPoint{get;set;}
    public Point EndPoint{get;set;}

    public Rectangle(){
        this.StartPoint=new Point(0,0);
        this.EndPoint=new Point(0,0);
    }

     public Rectangle(Point p1,Point p2){
        this.StartPoint=p1;
        this.EndPoint=p2;
    }

    public override void Draw()
    {
        Type t=this.GetType();
        Console.WriteLine("Type ="+t.Name);
        Console.WriteLine("("+this.StartPoint+"), ("+this.EndPoint+"), "+this.Width+" "+ this.Color);
    }

    public void print()
    {
        Console.WriteLine("Printing object on existing printer");
        Console.WriteLine("Type = "+this.GetType().Name);
        Console.WriteLine("("+this.StartPoint+"), ("+this.EndPoint+"), "+this.Width+" "+ this.Color);
    }
}