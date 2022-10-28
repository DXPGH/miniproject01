internal class Program
{
    class Student
    {
        public int id;
        public string name;
        public string dob;
        public char grade;
        private string[]? courses;

        public Student(int id, string name, string dob, char grade)
        {
            this.id = id;
            this.name = name;
            this.dob = dob;
            this.grade = grade;
        }

    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Student test = new Student(01, "Jack", "04/12/1956", 'B');
        Console.WriteLine("My ID is {0}, My name is {1}, and my DOB is {2} with a grade of {3}", test.id, test.name, test.dob, test.grade);

        Console.ReadLine();
    }
}