namespace Assignment_3._2;

public class FindIndex
{
     double[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
     public int SearchIndex(double[] numbers, double numberToFind)
     {
          for (int i = 0; i < numbers.Length; i++)
          {
               double currentNumber = numbers[i];
               if (currentNumber == numberToFind)
               {
                    return i;
               }
          }
          return -1;
     }

     public void PrintIndex()
     {
          Console.WriteLine($"Here is a list of numbers in an array: {string.Join(", ", numbers)}");
          Console.WriteLine("Please enter the number to find: ");
          double numberToFind = double.Parse(Console.ReadLine());
          
          Console.WriteLine($"The index of your number is: {SearchIndex(numbers, numberToFind)}");
     }
}