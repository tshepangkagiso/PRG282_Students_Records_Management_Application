using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Students_Records_Management_Application.Data.Models
{
    internal class Student
    {
        //private student fields
        private int StudentID { get; set; }
        private string StudentName { get; set; }
        private int StudentAge { get; set; }
        private string CourseName { get; set; }

        //Constructor with no params
        public Student() { }

        //Constructor with params
        public Student(int studentId, string studentName, int studentAge, string courseName)
        {
            _StudentID = studentId;
            _StudentName = studentName;
            _StudentAge = studentAge;
            _CourseName = courseName;
        }

        //public fields (encapsulation)
        public int _StudentID { get{ return StudentID; } set { StudentID = value; } }
        public string _StudentName { get { return StudentName; } set { StudentName = value; } }
        public int _StudentAge { get { return StudentAge; } set { StudentAge = value; } }
        public string _CourseName { get { return CourseName; } set { CourseName = value; } }

        // Static list collection to cache students
        public static List<Student> ListOfStudents = new List<Student>
    {
        new Student(555551, "Alice Johnson", 20, "PRG 281"),
        new Student(555552, "Bob Smith", 22, "PRG 281"),
        new Student(555553, "Charlie Brown", 21, "PRG 281"),
        new Student(555554, "Diana Prince", 23, "PRG 281"),
        new Student(555555, "Ethan Hunt", 24, "PRG 281")
    };

    }
}
