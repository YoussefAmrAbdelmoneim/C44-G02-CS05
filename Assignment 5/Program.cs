using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Program
    {
        #region Function Q1
        //public static void SwapByValue(int a, int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //    Console.WriteLine($"SwapByValue: a = {a}, b = {b}");
        //}
        //public static void SwapByRef(ref int a,ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //    Console.WriteLine($"SwapByRef: a = {a}, b = {b}");
        //}
        #endregion
        #region Function Q2
        public static int getSumValue(int[] array)
        {
            array = new int[] { 9, 9, 9, 9 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public static int getSumRef(ref int[] array)
        {
            array = new int[] { 9, 9, 9, 9 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum+= array[i];
            }
            return sum;
        }
        #endregion
        #region Function Q3
        //public static void SumAndSub(int a,int b, out int sum , out int sub)
        //{
        //    sum = a + b;
        //    sub = a - b;
        //}
        #endregion
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
            #region Array Q8
            //string word = Console.ReadLine() ?? "";
            //string[] words = word.Split(' ');
            //for (int i =words.Length -1 ; i >= 0; i--)
            //{
            //    if (words[i] != "")
            //    {
            //        Console.Write(words[i]);
            //        if (i > 0)
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            // }
            #endregion
            #region Array Q9
            //int[,] arr01 = new int[2,5];
            //int[,] arr02 = new int[2,5];
            //int number;
            //Console.WriteLine("Enter 10 integers for the 2x5 array:");
            //for (int i = 0; i < arr01.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr01.GetLength(1); j++)
            //    {
            //        int.TryParse(Console.ReadLine(), out number);
            //        arr01[i,j] = number;
            //    }
            //}
            //for (int i = 0; i < arr02.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr02.GetLength(1); j++)
            //    {
            //        arr02[i, j] = arr01[i, j];
            //    }
            //}
            //Console.Clear();
            //Console.WriteLine("Copied Array (arr02):");
            //for (int i = 0; i < arr02.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr02.GetLength(1); j++)
            //    {
            //        Console.WriteLine(arr02[i,j]);
            //    }
            //}         
            #endregion
            #region Array Q10
            //Console.WriteLine("Please enter size of array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //int[] arr = new int[size];
            //Console.WriteLine("Enter Numbers: ");
            //for (int i = 0; i < size; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out int number);
            //    arr[i] = number;
            //}
            //Console.WriteLine("Reversed array: ");
            //for (int i = size - 1 ; i >=0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            #endregion
            #region Function Q1
            //int a = 5;
            //int b = 10;
            ///*Passing by Value
            // * A copy of the variable is passed to the method.
            //*/
            //SwapByValue(a, b);
            //Console.WriteLine($"value of a: {a}");
            ///*Passing by reference
            // *The reference to the actual variable is passed.
            //*/
            //SwapByRef(ref a,ref b);
            //Console.WriteLine($"value of a: {a}");
            #endregion
            #region Function Q2
            //int[] array = { 1, 2, 3, 4 };
            /* Pass by value (Reference type parameters)
             * The reference itself is passed by value.
             */
            //Console.WriteLine(getSumValue(array));
            //Console.WriteLine(array[0]);
            /* Pass by reference (Reference type parameters)
             * The reference itself is passed by reference.
             */
            //Console.WriteLine(getSumRef(ref array));
            //Console.WriteLine(array[0]);
            #endregion
            #region Function Q3
            //int sum;
            //int sub;
            //SumAndSub(5, 4, out sum, out sub);
            //Console.WriteLine($"sum : {sum} , sub : {sub}");
            #endregion
        }
    }
}
