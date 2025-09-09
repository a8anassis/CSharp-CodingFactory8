namespace PalindromeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 2, 1 };
            bool isPalindrome = true;

            for (int i = 0, j = ints.Length - 1; i < j; i++, j--)
            {
                if (ints[i] != ints[j])
                {
                    isPalindrome = false;
                    break;
                }
            }

            Console.WriteLine($"Is Palindrome: {isPalindrome}");
        }
    }
}
