public abstract class Shape
{
    public abstract void GetArea();
    
}

public class Circle : Shape
{
    public override void GetArea()
    {
        const double Pi = 3.14;
        double radius = 7.0;
        double Area;

        Area = Pi * radius * radius;
    }
}

public class Rectangle : Shape
{
    public override void GetArea()
    {
        double length = 4.4;
        double width = 5.4;
        double Area;

        Area = length * width;
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.GetArea();

            Rectangle rectangle = new Rectangle();
            rectangle.GetArea();
        }
    }
}