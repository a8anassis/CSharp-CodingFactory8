using System.Text.RegularExpressions;

namespace StrHelperMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello,     World!";
            string str2 = "  Hello, C#!  ";

            string upper = str1.ToUpper(); // "HELLO, WORLD!"
            string lower = str1.ToLower(); // "hello, world!"

            string trimmed = str2.Trim();  // "Hello, C#!"

            bool result = str1.ToUpper() == str2.ToUpper();  // normalization for comparison

            int index = str1.IndexOf("World"); // 7
            int lastIndex = str1.LastIndexOf("o"); // 8

            bool contains = str1.Contains("World"); // true

            string substring = str1.Substring(7, 5); // "World"

            string[] words = str1.Split(','); // ["Hello", " World!"]
            string[] tokens = Regex.Split(str1, @"\W+"); // ["Hello", "World"]


            string replaced = str1.Replace("World", "C#"); // "Hello, C#!"
            string replacedRegex = Regex.Replace(str1, @"\s+", "_"); // "Hello,_World!"

            bool startsWith = str1.StartsWith("Hello"); // true
            bool endsWith = str1.EndsWith("!"); // true

            int length = str1.Length; // 13


            string formatted = string.Format("{0} and {1}", str1, 10); // "Hello, World!10"
         
            string joined = string.Join(", ", words); // "Hello,  World!"

            // Validation
            bool isNullOrEmpty = string.IsNullOrEmpty(str1); // false
            bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace("   "); // true
            
            
            string padded = str1.PadLeft(20).PadRight(25, '*'); // "       Hello, World!*****"
            
            
            string joined1 = string.Concat(str1, " ", str2); // "Hello, World!   Hello, C#!  "
            string joined2 = str1 + " " + str2; // "Hello, World!   Hello, C#!  "
         
            string reversed = new string(str1.Reverse().ToArray()); // "!dlroW ,olleH"


        }
    }
}
