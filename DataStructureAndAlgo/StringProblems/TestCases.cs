namespace StringProblems
{
    internal class TestCases
    {
        static void Main(string[] args)
        {
            //   ReverseString.PrintReverseStringForGivenIndexes("abdeagf", 2, 5);

            string testCase1 = "here-is-a-boy";
            // ReverseString.PrintReverseStringWordbyWord(testCase1);

            // ReverseString.PrintReverseStringWordbyWordOptimized(testCase1);

            //string str = "xbdyzzydbdyzydx";
            //LongestPallindrome.PrintLongestPallindromeStrLength(str);
            //LongestPallindrome.PrintLongestPallindromeStrLengthOptimized(str);

            char[] arrChar = { 'S', 'c', 'a', 'l', 'e', 'r', '#', '2', '0', '2', '0' };
            CheckArrayHasAlphabets.CheckIfArrayHasAlphabets(arrChar);
            Console.ReadKey();
        }
    }
}