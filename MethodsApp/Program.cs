using System.Text;

namespace MethodsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20;
            Swap(ref x, ref y);

            DateTime dateTime = GetDateTime(day: 15, month: 8);
            DateTime dateTime2 = GetDateTime(2026, 12, 25, 10, 30, 0);
            Console.WriteLine($"{dateTime:F}");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Αναδρομική συνάρτηση για τον υπολογισμό του παραγοντικού ενός αριθμού
        public static int Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }

        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }


        // Συνάρτηση που δέχεται μεταβλητό αριθμό παραμέτρων
        // Add(1, 9, 12)
        // Java -> varargs -> int...
        // JavaScript -> ...rest
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        // Optional parameters
        public static DateTime GetDateTime(int year = 2025, int month = 1, int day = 1,
                                           int hour = 0, int minute = 0, int second = 0)
        {
            return new DateTime(year, month, day, hour, minute, second, DateTimeKind.Utc);
        }

        public static void PrintMessage(string message = "Hello, World!")
        {
            Console.WriteLine(message);
        }

        public static void PrintMessage(string prefix = "Message:", string message = "Hello, World!")
        {
            Console.WriteLine($"{prefix} {message}");
        }

        public static void PrintMessage(int inputNum)
        {
            Console.WriteLine($"{inputNum}");
        }


        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        public static bool IsEven(int number)
        {
            return !IsOdd(number);
        }

        public static int GetMax(int a, int b) 
        {
            return Math.Max(a, b);
        }

        public static double CelciusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        // StringBuilder
        public static string StrRepeat(string? s, int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(s);
            }
            return sb.ToString();
        }

        // "abBA"
        public static bool IsPalindromeIgnoreCase(string s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (char.ToUpper(s[i]) != char.ToUpper(s[j]))
                {
                    return false;
                }
            }
            return true;
        }

        public static string RandomPinFourDigits()
        {
            Random random = new Random();
            int pin = random.Next(1000, 10000); // Generates a number between 1000 and 9999
            return pin.ToString();
        }

        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j+1]
                        (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
                    }
                }
            }
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }


        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

    }
}
