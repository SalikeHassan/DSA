namespace RecursionProblems
{
    internal class TestCases
    {
        static void Main(string[] args)
        {
            //var sum = SumOfDigits.GetSum(102);
            //Console.WriteLine(sum);

            ////var pow = PowerFunction.GetPow(2, 3, 3);
            //var pow = PowerFunction.GetPow(-1, 1, 20);
            //Console.WriteLine(pow);

            //Console.WriteLine(Pallindrome.IsStringPallindrome("3553", 0, "3553".Length - 1));
            //Console.WriteLine(Pallindrome.IsStringPallindrome("naman", 0, "naman".Length - 1));
            //Console.WriteLine(Pallindrome.IsStringPallindrome("strings", 0, "strings".Length - 1));

            Console.WriteLine(Fibonacci.GetAthFibonacci(2));
            Console.WriteLine(Fibonacci.GetAthFibonacci(9));

            ReverseString.Reverse("cool", "cool".Length - 1);

            Console.ReadKey();
        }
    }
}