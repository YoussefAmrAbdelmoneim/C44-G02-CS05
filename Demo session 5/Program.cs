namespace Demo_session_5
{
    internal class Program
    {
        #region Methods
        //public static void printShape(string shape =":)" , int count =5)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine(shape);
        //    }
        //}
        //public static void swap(ref int x, ref int y)
        //{
        //    int temp =x ;
        //    x = y;
        //    y = temp;
        //}
        public static int getSumArray(ref int[] array)
        {
            int sum = 0;
            if (array is not null)
            {
                array[0] = 100;
            for (int i = 0; i < array.Length; i++)
             {
                sum += array[i];
             }
            }
            return sum;
        }
        #endregion
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
            #region Functions
            #region Function Prototype
            //printShape();
            //printShape(@"/:\", 10);
            #endregion
            #region Function Parameters [Value Type]
            #region Passing by value
            //int a = 5, b = 10;
            //swap(a, b);
            #endregion
            #region Passing by ref
            //int a = 5, b = 10;
            //swap(ref a, ref b);
            //Console.WriteLine(a);
            #endregion
            #endregion
            #region Function Parameters [reference type]
            #region Passing by value
            //int[] numbers = { 1, 2, 3 };
            //Console.WriteLine(numbers[0]);
            //int result = getSumArray(numbers);
            //Console.WriteLine(result);
            //Console.WriteLine(numbers[0]);
            #endregion
            #region Passing by ref
            //int[] numbers = { 1, 2, 3 };
            //Console.WriteLine(numbers[0]);
            //int result = getSumArray(ref numbers);
            //Console.WriteLine(result);
            //Console.WriteLine(numbers[0]);
            #endregion
            #endregion
            #endregion
        }
    }
}
