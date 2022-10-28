using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

internal class Program
{
    class Student
    {
        private int studID;
        private string studName;
        private string studDOB;
        private char studGrade;
        public string[] courses = { "Empty", "Empty", "Empty", "Empty" };
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
        Console.WriteLine("Would you like to view");
        Console.WriteLine("0: ID, 1: Name, 2: DOB, 3: Grade, 4: Courses");
        int val1;
        string value = Console.ReadLine();
        val1 = Convert.ToInt16(value);

        switch (val1)
        {
            case 0:
                Console.WriteLine("Your ID is {0}",test.getID());
                break;
            case 1:
                Console.WriteLine("Your name is {0}", test.getName());
                break;
            case 2:
                Console.WriteLine("Your DOB is {0}", test.getDOB());
                break;
            case 3:
                Console.WriteLine("Your grade is {0}", test.getGrade());
                break;
            case 4:
                Console.WriteLine("Here are your courses");
                test.getCoursesofStudent();
                break;
        }
    }

    static void changeStudentData(Student test)
    {
        Console.WriteLine("You are now inside changeStudentData");
        Console.WriteLine("Would you like to change");
        Console.WriteLine("0: DOB, 1: Grades, 2: Courses");
        int val1;
        string value = Console.ReadLine();
        val1 = Convert.ToInt16(value);

        switch (val1)
        {
            case 0:
                Console.WriteLine("Input a new DOB");
                string newDOB = Console.ReadLine();
                test.setDOB(newDOB);
                break;
            case 1:
                Console.WriteLine("Input a letter char for an updated grade");
                string newGradeSTR = Console.ReadLine();
                char newGrade = Convert.ToChar(newGradeSTR);
                test.setGrade(newGrade);
                break;
            case 2:
                Console.WriteLine("Input a course you would like to implement");
                Console.WriteLine("0: Band, 1: Math, 2: Science, 3: History");
                string courseNumStr = Console.ReadLine();
                int courseNum = Convert.ToInt16(courseNumStr);
                string[] newCourses = {"", "", "", ""};

                // Nested switch case for choosing what class to add to courses
                switch(courseNum)
                {
                    case 0:
                        newCourses[0] = "Band";
                        test.courses = newCourses;
                        Console.WriteLine("Band has been added to your courses!");
                        break;
                    case 1:
                        newCourses[1] = "Math";
                        test.courses = newCourses;
                        Console.WriteLine("Math has been added to your courses!");
                        break;
                    case 2:
                        newCourses[2] = "Science";
                        test.courses = newCourses;
                        Console.WriteLine("Science has been added to your courses!");
                        break;
                    case 3:
                        newCourses[3] = "History";
                        test.courses = newCourses;
                        Console.WriteLine("History has been added to you courses!");
                        break;
                }
                break;
        }
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