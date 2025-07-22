using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array Q1
            //int sum = 0;
            //int size;
            //Console.WriteLine("Please enter size of array");
            //int.TryParse(Console.ReadLine(), out size);
            //int[] numbers = new int[size];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write("enter number in array : ");
            //    int.TryParse(Console.ReadLine(), out numbers[i]);
            //    sum += numbers[i];
            //}
            //Console.WriteLine($"Sum of numbers : {sum}");
            #endregion
            #region Array Q2
            //int[] arr01 = {2,1,3,5,4};
            //int[] arr02 = {8,7,6,9,10};
            //int[] mergedArray = new int[10];
            //for (int i = 0; i < arr01.Length; i++)
            //{
            //    mergedArray[i] = arr01[i];
            //}
            //for (int i = 0; i < arr02.Length; i++)
            //{
            //    mergedArray[arr01.Length + i] = arr02[i];
            //}
            //Array.Sort(mergedArray);
            //for (int i = 0; i < mergedArray.Length; i++)
            //{
            //    Console.WriteLine(mergedArray[i]);
            //}
            #endregion
            #region Array Q3
            //int[] arr = { 10, 20, 30, 10, 20, 10, 40, 50 };
            //bool[] counted = new bool[arr.Length];
            //Console.WriteLine("Frequency of each element:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (counted[i]) 
            //     continue;

            //    int count = 1;
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //            counted[j] = true;
            //        }
            //    }
            //    Console.WriteLine($"Element {arr[i]} appears {count} times");
            //}
            #endregion
            #region Array Q4
            //int[] arr = {1,2,3,4,5,6,7,8};
            //int max = arr[0];
            //int min = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    else if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine($"Maximum number is {max} \nMinimum number is {min}");
            #endregion
            #region Array Q5
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int max = arr[0];
            //int secondLargestElement = max;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        secondLargestElement = max;
            //        max = arr[i];
            //    }
            //    else if (arr[i] > secondLargestElement && arr[i] != max)
            //    {
            //        secondLargestElement = arr[i];
            //    }
            //}
            //Console.WriteLine(secondLargestElement);
            #endregion
            #region Array Q6,Q7
            //Console.WriteLine("Please enter size of array");
            //int.TryParse(Console.ReadLine(), out int size);
            //int[] arr = new int[size];
            //int maxDistance = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out int number);
            //    arr[i] = number;
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = size -1 ; j > i; j--)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i - 1;
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //            }
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine("The longest distance between equal elements is: " + maxDistance);
            #endregion
        }
    }
}
