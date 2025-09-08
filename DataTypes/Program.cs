namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"int: {sizeof(int) * 8} bits\t{int.MinValue}\t{int.MaxValue}");
            Console.WriteLine($"byte: {sizeof(byte) * 8} bits\t{byte.MinValue}\t{byte.MaxValue}");
            Console.WriteLine($"short: {sizeof(short) * 8} bits\t{short.MinValue}\t{short.MaxValue}");
            Console.WriteLine($"long: {sizeof(long) * 8} bits\t{long.MinValue}\t{long.MaxValue}");
            Console.WriteLine($"float: {sizeof(float) * 8} bits\t{float.MinValue}\t{float.MaxValue}");
            Console.WriteLine($"double: {sizeof(double) * 8} bits\t{double.MinValue}\t{double.MaxValue}");
            Console.WriteLine($"decimal: {sizeof(decimal) * 8} bits\t{decimal.MinValue}\t{decimal.MaxValue}");
        }
    }
}
