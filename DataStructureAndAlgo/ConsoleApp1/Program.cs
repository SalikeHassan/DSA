namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(foo(3, 5));
            Console.ReadKey();
        }

        internal static int foo(int x, int y)
        {
           // Console.Write("Foo");
            if (y == 0)
            {
                return 1;
            }
            else
            {
                return bar(x, foo(x, y - 1));
            }
        }

        internal static int bar(int x, int y)
        {
          //  Console.WriteLine("Bar");
            if (y == 0)
            {
                return 0;
            }
            else
            {
                return (x + bar(x, y - 1));
            }
        }
    }
}