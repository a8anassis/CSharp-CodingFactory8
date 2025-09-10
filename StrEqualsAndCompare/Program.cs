namespace StrEqualsAndCompare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "AUEB";
            string s2 = "AUEB";

            Console.WriteLine($"{s1.Equals(s2)}");  // ισότητα περιεχομένου
            Console.WriteLine($"{s1 == s2}");       // ισότητα περιεχομένου
            Console.WriteLine($"{ReferenceEquals(s1, s2)}"); // ισότητα αναφοράς

            int result = s1.CompareTo(s2); // λεξικογραφική σύγκριση
            int result2 = string.Compare("HELLO", "hello", true); // λεξικογραφική σύγκριση -- null safe
        }
    }
}
