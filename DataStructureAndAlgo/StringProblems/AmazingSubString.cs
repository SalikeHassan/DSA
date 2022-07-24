namespace StringProblems
{
    internal static class AmazingSubString
    {
        internal static void CountAmazingSubstring(string str)
        {
            char[] arrChars = str.ToCharArray();
            int size = arrChars.Length;
            int cnt = 0;

            for (int idx = 0; idx < size; idx++)
            {
                if (arrChars[idx] == 'a' ||
                        arrChars[idx] == 'e' ||
                        arrChars[idx] == 'i' ||
                        arrChars[idx] == 'o' ||
                        arrChars[idx] == 'u' ||
                        arrChars[idx] == 'A' ||
                        arrChars[idx] == 'E' ||
                        arrChars[idx] == 'I' ||
                        arrChars[idx] == 'O' ||
                        arrChars[idx] == 'U'
                    )
                {
                    cnt += size - idx;
                    cnt %= 10003;
                }
            }

            int res = cnt % 10003;

            Console.WriteLine(res);
        }
    }
}
