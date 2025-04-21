namespace Assignment_3._2;

public class TotalAndAverage
{
    private double CalculateAverage(double[] numbers)
    {
        double total = 0;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            total += numbers[i];
        }
        double average = total / numbers.Length;
        return average;
    }

    private double CalculateTotal(double[] numbers)
    {
        double total = 0;
        
        foreach (double number in numbers)
        {
            total += number;
        }
        return total;
    }

    public double[] GetNumbersFromUser()
    {
        double[] numbers = new double[4];
        
        Console.Write("Please enter first number: ");
        numbers[0] = double.Parse(Console.ReadLine());
        Console.Write("Please enter second number: ");
        numbers[1] = double.Parse(Console.ReadLine());
        Console.Write("Please enter third number: ");
        numbers[2] = double.Parse(Console.ReadLine());
        Console.Write("Please enter fourth number: ");
        numbers[3] = double.Parse(Console.ReadLine());
        return numbers;
    }
    
    public void PrintTotalAndAverage(double[] numbers)
    {
        double total = CalculateTotal(numbers);
        double average = CalculateAverage(numbers);
        Console.WriteLine($"The total is: {total:F2}");
        Console.WriteLine($"The average is: {average:F2}");
    }
}