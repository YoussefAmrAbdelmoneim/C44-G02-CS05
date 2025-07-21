namespace Demo_session_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array
            #region 1D Array
            //int[] numbers01 = new int[3];
            //int[] numbers02 = new int[] { 1, 2, 3 };
            //int[] numbers03 = { 1, 2, 3 };
            //int[] numbers04 = [1, 2, 3];
            #endregion
            #region 2D Array
            #region Ex 1
            //int[,] Marks = new int[2, 5];
            //Take Data from user

            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Grades of student no {i+1} = ");
            //    for (int j = 0; j < Marks.GetLength(1); )
            //    {
            //        Console.Write($"Subject no {j+1} : ");
            //        bool isParsed = int.TryParse(Console.ReadLine(), out Marks[i, j]);
            //        if (isParsed)
            //        {
            //            j++;
            //        }
            //    }
            //        Console.WriteLine("============================");
            //}

            // print elements

            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Grades of student no {i + 1} = ");
            //    for (int j = 0; j < Marks.GetLength(1);j++)
            //    {
            //        Console.WriteLine($"Marks of subject no {j + 1} = {Marks[i,j]} ");
            //    }
            //    Console.WriteLine("============================");
            //}
            #endregion
            #region Ex 2
            //int[,] marks = new int[2, 4];
            //for (int i = 0; i < marks.Length;)
            //{
            //    bool isParsed = int.TryParse(Console.ReadLine(), out int studentMark);
            //    if (isParsed)
            //    {
            //        ++i;
            //        marks[i/marks.GetLength(1),i%marks.GetLength(1)] = studentMark;
            //    }
            //}
            ////print
            //for (int i = 0; i < marks.length; i++)
            //{
            //    Console.WriteLine(marks[i / marks.GetLength(1), i % marks.GetLength(1)]);
            //}
            #endregion
            #endregion
            #region Jagged Array
            //int[][] JaggedArray = new int[3][];
            //JaggedArray[0] = new int[4];
            //JaggedArray[1] = new int[] {10,20};
            //JaggedArray[2] = [30, 40, 50];
            #endregion
            #endregion
            #region Array methods
            #region Class member methods
            //int[] numbers = { 5, 3, 4, 1, 2, 4 };
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //Array.Clear(numbers,2,3);
            //Console.WriteLine(Array.IndexOf(numbers,4));
            //Console.WriteLine(Array.LastIndexOf(numbers,4));
            //Array.Resize(ref numbers,10);
            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //int[] arr01 = { 1, 2, 3, 4, 5 };
            //int[] arr02 = new int[4];
            //Array.Copy(arr01,arr02,4);
            //Array.ConstrainedCopy(arr01, 1, arr02, 1, 2);
            //Console.ReadKey();
            #endregion
            #region Object member methods
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //numbers.GetLength(0);
            //Console.WriteLine(numbers.Length);
            //int element = (int) numbers.GetValue(1);
            //element = numbers[1];
            //numbers[0] = 100;
            //numbers.SetValue(100, 0);
            #endregion
            #endregion
        }
    }
}
