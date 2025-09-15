namespace StudentApp
{
    internal class Program
    {
        // Default constructor is provided
        static void Main(string[] args)
        {
            Student alice = new Student();
            Student bob = new();
            var costas = new Student();

            Student student = new Student();
            Student student1 = new Student(1, "Alice", "W.");

            // χρειάζεται setters
            //Student student2 = new() { Id = 2, Firstname = "Γιάννης", Lastname = "Γεωργίου" };

            Teacher teacher = new() { Id = 1, Firstname = "Αθαν.", Lastname = "Ανδρούτσος" };
            teacher.Id = 1;
            teacher.Firstname = "Κων/νος";
            teacher.Lastname = "Λάμπρου";

            Console.WriteLine($"Id={teacher.Id}, Firstname={teacher.Firstname}, " +
                $"Lastname={teacher.Lastname}");

        }
    }
}
