namespace Assignment_3._2;

public class Circle
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }
    public double Area()
    {
        return Math.PI * (Radius * Radius);
    }

    public static Circle operator +(Circle c1, Circle c2)
    {
        double newArea = c1.Area() + c2.Area();
        double newRadius = Math.Sqrt(newArea / Math.PI);;
        return new Circle(newRadius);
    }
    
    public static Circle operator -(Circle c1, Circle c2)
    {
        double newArea = c1.Area() - c2.Area();
        double newRadius = Math.Sqrt(newArea / Math.PI);
        return new Circle(newRadius);
    }


    public void PrintResults()
    {
        Console.WriteLine("Please enter the radius of the first circle:");
        double radius1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Please enter the radius of the second circle:");
        double radius2 = double.Parse(Console.ReadLine());
        
        Circle c1 = new Circle(radius1);
        Circle c2 = new Circle(radius2);
        
        Circle sumCircle = c1 + c2;
        Circle diffCircle = c1 - c2;
        
        Console.WriteLine($"The area of the first circle is: {c1.Area():F2}");
        Console.WriteLine($"The area of the second circle is: {c2.Area():F2}");
        Console.WriteLine($"A circle with the sum of the areas has:");
        Console.WriteLine($"  - Radius: {sumCircle.Radius:F2}");
        Console.WriteLine($"  - Area: {sumCircle.Area():F2}");
        Console.WriteLine($"A circle with the difference of the areas has:");
        Console.WriteLine($"  - Radius: {diffCircle.Radius:F2}");
        Console.WriteLine($"  - Area: {diffCircle.Area():F2}");
    }
}