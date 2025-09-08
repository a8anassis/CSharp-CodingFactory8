namespace ExpressionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            int sum = 0;
            int sub = 0;
            int mul = 0;
            int div = 0;
            int mod = 0;
            int result = 0;
            int finalResult = 0;

            sum = num1 + num2;
            sub = num1 - num2;
            mul = num1 * num2;
            div = num1 / num2;
            mod = num1 % num2;

            result = sum++;
            result = ++sub;

            result += sum;
            result -= 5;
            result *= 2;
            result /= 2;

            finalResult = (num1 + num2) * (num2 / num1++) % num2;

            Console.WriteLine($"{finalResult}");
        }
    }
}
