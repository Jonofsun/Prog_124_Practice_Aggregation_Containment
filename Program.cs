namespace Prog_124_Practice_Aggregation_Containment
{
    internal class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            Instructor John = new Instructor("Jonathan","Reed");
            SchoolProgram prog124 = new SchoolProgram("Programming", "124", "J124", John);
            students.Add(new Student("Nami", "Neko", 100, 99));
            prog124.AddStudent("Nami","Neko",100,99); // Something messed up
            for (int i = 0; i <  students.Count; i++)
            {
                Console.WriteLine(prog124.ToString());
            }
            Console.WriteLine(John.ToString());
            Console.WriteLine(students.ToString());
        }
        
    }
}