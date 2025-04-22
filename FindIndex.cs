namespace Assignment_3._2;

public class FindIndex
{
     double[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
     public int SearchIndex(double[] numberArray, double numberToFind)
     {
          for (int i = 0; i < numberArray.Length; i++)
          {
               if (numberArray[i] == numberToFind)
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
          
          Console.WriteLine($"The index of your number {numberToFind}, is at position: {SearchIndex(numbers, numberToFind)}");
     }

     public int Search(int[] array, int value)
     {
          for (int i = 0; i < array.Length; i++)
          {
               if (array[i].Equals(value))// using Equals() method instead of == operator just to show it
               {
                    Console.WriteLine($"""
                                       The index of {value} 
                                       in the array: [{string.Join(", ", array)}]
                                       is at position: {i}
                                       """);
                    return i;
               }
          }

          Console.WriteLine("The value is not in the array");
          return -1;
     }
}