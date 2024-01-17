
using System.Collections.Concurrent;

namespace d1;
internal class Program
{
    private static void Main(string[] args)
    {
        //MathL.MathCase();
        //double lol = MathL.L(2.0);
        //Console.WriteLine(lol);
        //Console.WriteLine(MathL.IsPrimeNumber(2));
        Console.WriteLine("Quiz 1");
        Quiz.Quiz1(5);
        Console.WriteLine("Quiz 2");
        Quiz.Quiz2();
        Console.WriteLine("Quiz 3");
        Quiz.Quiz3(15);
        Quiz.Quiz3(25);
        Quiz.Quiz3(50);
        Console.WriteLine("Quiz 4");
        Quiz.Quiz4(24);
        Quiz.Quiz4(6);
        Quiz.Quiz4(7);
        Console.WriteLine("Quiz 5");
        Quiz.Quiz5(5);
        Quiz.Quiz5(9);
        Console.WriteLine("Quiz 6");
        Quiz.Quiz6(5);
        Quiz.Quiz6(9);
        Console.WriteLine("Quiz 7");
        Quiz.Quiz7(28);
        Quiz.Quiz7(1000);
        Quiz.Quiz7(10000);
        Console.WriteLine("Quiz 8");
        Console.WriteLine(Quiz.Quiz8(121));
        Console.WriteLine(Quiz.Quiz8(2147447412));
        Console.WriteLine(Quiz.Quiz8(333));
        Console.WriteLine(Quiz.Quiz8(110));


    }
}