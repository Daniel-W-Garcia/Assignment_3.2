﻿namespace Assignment_3._2;

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

    public static double operator *(Circle c1, Circle c2)
    {
        return c1.Area() * c2.Area();
    }

    public static Circle operator +(Circle c1, Circle c2)
    {
        double newArea = c1.Area() + c2.Area();
        double newRadius = Math.Sqrt(newArea / Math.PI);;
        return new Circle(newRadius);
    }

    /*public static double operator +(Circle c1, Circle c2)
    {
        double newArea = c1.Area() + c2.Area();
        return newArea;
    }*/

    public void Area(double radius)
    {
        Console.WriteLine(Area());
    }
    
    public static Circle operator -(Circle c1, Circle c2)
    {
        double newArea = c1.Area() - c2.Area();
        double newRadius = Math.Sqrt(newArea / Math.PI);
        return new Circle(newRadius);
    }


    public static void PrintResults()
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
        Console.WriteLine($"A circle with the sum of both areas has a:");
        Console.WriteLine($"  - Radius of: {sumCircle.Radius:F2}");
        Console.WriteLine($"  - Area of: {sumCircle.Area():F2}");
        Console.WriteLine($"A circle with the difference of the two areas has a:");
        Console.WriteLine($"  - Radius of: {diffCircle.Radius:F2}");
        Console.WriteLine($"  - Area of: {diffCircle.Area():F2}");
    }
}