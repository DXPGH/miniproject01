using System.Reflection.PortableExecutable;

internal class Program
{
    class Student
    {
        private int studID;
        private string studName;
        private string studDOB;
        private char studGrade;
        private string[] courses = {"Band", "Math", "Science", "History"};
        private readonly int studentsNum;

        // Each student will have: name, DOB, ID, grade, courses
        public Student(int id, string name, string dob, char grade)
        {
            this.studID = id;
            this.studName = name;
            this.studDOB = dob;
            this.studGrade = grade;
            studentsNum++;
        }

        // Setters

        // Set the dob
        public void setDOB(string newDOB)
        {
            this.studDOB = newDOB;
            Console.WriteLine("Date of Birth Successfully changed to {0}", newDOB);
        }

        // Set the grade
        public void setGrade(char newGrade)
        {
            this.studGrade = newGrade;
            Console.WriteLine("Grade has Successfully be changed to {0}", newGrade);
        }

        // Set the courses
        public void setCourses(string[] newCourses)
        {
            this.courses = newCourses;
        }

        // Getters

        // Get the student id
        public string getID()
        {
            return studID.ToString();
        }

        // Get the student name
        public string getName()
        {
            return studName;
        }

        // Get the DOB
        public string getDOB()
        {
            return studDOB;
        }

        // Get the grade
        public string getGrade()
        {
            return studGrade.ToString();
        }

        // Get the courses
        public void getCoursesofStudent()
        {
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }
        }

        // Get the total number of students in a class. 
        public string getStudentNum()
        {
            return studentsNum.ToString();
        }

    }

    static bool viewOrChange(Student test)
    {
        int val1;
        string firstVal;

        Console.WriteLine("Would you like to view student data '0' or change student data '1' or exit '2'?");
        firstVal = Console.ReadLine();
        val1 = Convert.ToInt16(firstVal);

        switch (val1)
        {
            case 0:
                viewStudentData(test);
                break;
            case 1:
                changeStudentData(test);
                break;
            case 2:
                Console.WriteLine("Thanks for using my program!");
                break;
        }
        return true;
    }

    static void viewStudentData(Student test)
    {
        Console.WriteLine("You are now inside viewStudentData");
        Console.WriteLine("Would you like to view id '0', name '1', DOB '2', grade '3', courses '4'");
        int val1;
        string value = Console.ReadLine();
        val1 = Convert.ToInt16(value);

        switch (val1)
        {
            case 0:
                Console.WriteLine("Your ID is {0}",test.getID());
                break;
            case 1:
                test.getName();
                break;
            case 2: 
                test.getDOB();
                break;
            case 3:
                break;
        }
    }

    static void changeStudentData(Student test)
    {
        Console.WriteLine("You are now inside changeStudentData");
    }

    public static void Main(string[] args)
    {
        // Test case
        Console.WriteLine("Hello, World!");
        Student test = new Student(01, "Jack", "04/12/1956", 'B');
        Console.WriteLine($"My student ID is {test.getID()}, My name is {test.getName()}, My DOB is {test.getDOB()}, and my grade is {test.getGrade()}");
        Console.WriteLine($"There is {test.getStudentNum()} student");
        

        bool done = false;

        // Actual application portion for user to input/update data
        while(!done)
        {
            done = viewOrChange(test);
        }

        Console.ReadLine();
    }
}