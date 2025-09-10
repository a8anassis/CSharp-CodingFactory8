using System.Text;

namespace StrBuilderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine(DateTime.Now);
            sb.Append("Numbers: ");

            for (int i = 1; i <= 100_000_000; i++)
            {
                sb.Append(i);
            }

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(sb.ToString().Substring(0, 128));
        }
    }
}
