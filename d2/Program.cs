using System;

using d2;

internal class Program
{
    private static void Main(string[] args)
    {
        //Arr.IntroArray();
        //int[] arrInt = Arr.InitArrayInteger(10);
        //int sum = Arr.SumArrayInteger(arrInt);
        //Console.WriteLine($"Sum of array is {sum}");
        //int max = Arr.MaxArrayInteger(arrInt);
        //Console.WriteLine($"Max of array is {max}");
        //var destArr = Arr.CopyArrayInteger(arrInt);
        //Arr.DisplayInitArrayInteger(destArr);

        //int[,] matrix = Matrix.FillRandomMatrix(5, 5);
        //Matrix.DisplayMatrix(matrix);

        ////Array No 1. Remove duplicate character from string
        //Console.WriteLine("Array No. 1");
        //Console.WriteLine(ArrayQuiz.Quiz1("bananas"));
        //Console.WriteLine(ArrayQuiz.Quiz1("lalalamama"));
        //Console.WriteLine(ArrayQuiz.Quiz1("romairama"));

        ////Array No 2. Capitalize first letter of each word
        //Console.WriteLine("Array No. 2");
        //Console.WriteLine(ArrayQuiz.Quiz2("codeid bootcamp"));
        //Console.WriteLine(ArrayQuiz.Quiz2("black pink venom"));

        ////Array No 3. Capitalize first letter of each word except with same value
        //Console.WriteLine("Array No. 3");
        //string[] arrStr = { "code", "java", "cool" };
        //string[] result = ArrayQuiz.Quiz3(arrStr, "java");
        //for (int i = 0; i < result.Length; i++)
        //{
        //    Console.Write($"{result[i]} ");
        //}
        //Console.WriteLine();
        //string[] arrStr2 = { "black", "pink", "venom"};
        //string[] result2 = ArrayQuiz.Quiz3(arrStr2, "venom");
        //for (int i = 0; i < result2.Length; i++)
        //{
        //    Console.Write($"{result2[i]} ");
        //}
        //Console.WriteLine();

        ////Array No 4. Check if branch is valid or not
        //Console.WriteLine("Array No. 4");
        //Console.WriteLine(ArrayQuiz.Quiz4("(())"));
        //Console.WriteLine(ArrayQuiz.Quiz4("()()"));
        //Console.WriteLine(ArrayQuiz.Quiz4("((()"));

        ////Array No 5. Find Min and Max value of array
        //Console.WriteLine("Array No. 5");
        //int[] arrInt = { 2, 3, 4, 5, 6, 7, 8, 9, 1, 10 };
        //int[] quiz5 = ArrayQuiz.Quiz5(arrInt);
        //for (int i = 0; i < quiz5.Length; i++)
        //{
        //    Console.Write($"{quiz5[i]} ");
        //}
        //Console.WriteLine();

        ////Array No. 6A Find Min and index of Min on specific range
        //Console.WriteLine("Array No. 6A");
        //int[] arr6A1 = { 5, 3, 4, 2, 6, 7, 8, 9, 1, 10 };
        //int[] quiz6A1 = ArrayQuiz.Quiz6A(arr6A1, 0, 10);
        //for (int i = 0; i < quiz6A1.Length; i++)
        //{
        //    Console.Write($"{quiz6A1[i]} ");
        //}
        //Console.WriteLine();
        //int[] arr6A2 = { 5, 3, 4, 2, 6, 7, 8, 9, 1, 10 };
        //int[] quiz6A2 = ArrayQuiz.Quiz6A(arr6A2, 0, 7);
        //for (int i = 0; i < quiz6A2.Length; i++)
        //{
        //    Console.Write($"{quiz6A2[i]} ");
        //}
        //Console.WriteLine();
        //Console.WriteLine("Array No. 6B");
        //int[] arr6B1 = { 1, 22, 3, 4, 5, 10, 7, 8, 9, 49 };
        //int[] quiz6B1 = ArrayQuiz.Quiz6B(arr6B1, 0, 10);
        //for (int i = 0; i < quiz6B1.Length; i++)
        //{
        //    Console.Write($"{quiz6B1[i]} ");
        //}
        //Console.WriteLine();
        //int[] arr6B2 = { 1, 22, 3, 4, 5, 10, 7, 8, 9, 49 };
        //int[] quiz6B2 = ArrayQuiz.Quiz6B(arr6B2, 2, 7);
        //for (int i = 0; i < quiz6B2.Length; i++)
        //{
        //    Console.Write($"{quiz6B2[i]} ");
        //}
        //Console.WriteLine();

        ////Array No. 7 even sort then odd sort in odd without concern about order
        //Console.WriteLine("Array No. 7");
        //int[] arr71 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //arr71 = ArrayQuiz.Quiz7(arr71);
        //for (int i = 0; i < arr71.Length; i++)
        //{
        //    Console.Write($"{arr71[i]} ");
        //}
        //Console.WriteLine();
        //int[] arr72 = { 2, 4, 6, 1, 8 };
        //arr72 = ArrayQuiz.Quiz7(arr72);
        //for (int i = 0; i < arr72.Length; i++)
        //{
        //    Console.Write($"{arr72[i]} ");
        //}
        //Console.WriteLine();

        ////Array No. 8 plus one to array and split if number > 9
        //Console.WriteLine("Array No. 8");
        //int[] arr81 = { 1, 2, 3 };
        //arr81 = ArrayQuiz.Quiz8(arr81);
        //for (int i = 0; i < arr81.Length; i++)
        //{
        //    Console.Write($"{arr81[i]} ");
        //}
        //Console.WriteLine();
        //int[] arr82 = { 4, 3, 2, 1 };
        //arr82 = ArrayQuiz.Quiz8(arr82);
        //for (int i = 0; i < arr82.Length; i++)
        //{
        //    Console.Write($"{arr82[i]} ");
        //}
        //Console.WriteLine();
        //int[] arr83 = { 9 };
        //arr83 = ArrayQuiz.Quiz8(arr83);
        //for (int i = 0; i < arr83.Length; i++)
        //{
        //    Console.Write($"{arr83[i]} ");
        //}
        //Console.WriteLine();
        //int[] arr84 = { 1, 2, 3, 9 };
        //arr84 = ArrayQuiz.Quiz8(arr84);
        //for (int i = 0; i < arr84.Length; i++)
        //{
        //    Console.Write($"{arr84[i]} ");
        //}
        //Console.WriteLine();
        //int[] arr85 = { 4, 9 };
        //arr85 = ArrayQuiz.Quiz8(arr85);
        //for (int i = 0; i < arr85.Length; i++)
        //{
        //    Console.Write($"{arr85[i]} ");
        //}
        //Console.WriteLine();

        ////Array No. 9 Rotate just only last row and the most right one move to left one
        //Console.WriteLine("Array No. 9");
        //int[,] arr91 = { { 0, 1, 2, 3, 4 }, { 12, 15, 1, 5, 20 } };
        //arr91 = ArrayQuiz.Quiz9(arr91, 3);
        //for (int i = 0; i < arr91.GetLength(0); i++)
        //{
        //    for (int j = 0; j < arr91.GetLength(1); j++)
        //    {
        //        Console.Write($"{arr91[i, j]} ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();

        //Matrix No. 1
        //Console.WriteLine("Matrix No. 1");
        //int[,] matrix1 = MatrixQuiz.Quiz1();
        //Console.WriteLine();
        //Console.WriteLine("Matrix No. 2");
        //int[,] matrix2 = MatrixQuiz.Quiz2(7);
        //Console.WriteLine();
        //Console.WriteLine("Matrix No. 3");
        //int[,] matrix3 = MatrixQuiz.Quiz3(7);
        //Console.WriteLine();
        //Console.WriteLine("Matrix No. 4");
        //int[,] matrix4 = MatrixQuiz.Quiz4();
        //Console.WriteLine();
        //// Matrix No. 5
        //Console.WriteLine("Matrix No. 5");
        //char[,] studentAnswers = {
        //    {  'A', 'B', 'A', 'C', 'C', 'D','E', 'E', 'A', 'D' },
        //    {  'D', 'B', 'A', 'B', 'C', 'A','E', 'E', 'A', 'D' },
        //    {  'E', 'D', 'D', 'A', 'C', 'B','E', 'E', 'A', 'D' },
        //    {  'C', 'B', 'A', 'E', 'D', 'C','E', 'E', 'A', 'D' },
        //    {  'A', 'B', 'D', 'C', 'C', 'D','E', 'E', 'A', 'D' },
        //    {  'B', 'B', 'E', 'C', 'C', 'D','E', 'E', 'A', 'D' },
        //    {  'B', 'B', 'A', 'C', 'C', 'D','E', 'E', 'A', 'D' },
        //    {  'E', 'B', 'E', 'C', 'C', 'D','E', 'E', 'A', 'D' }
        //};

        //char[] answers = { 'D', 'B', 'D', 'C', 'C', 'D', 'A', 'E', 'A', 'D' };
        //MatrixQuiz.Quiz5(studentAnswers, answers);

    }
}