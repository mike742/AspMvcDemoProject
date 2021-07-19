using AspMvcDemoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvcDemoProject.Data
{
    public class Repository
    {
        private static List<Course> _courses = new List<Course>
        {
            new Course {CourseID = 23, CourseNumber = 1, CourseName = "Skateboarding 101", CourseDescription = "Learn how to skateboard"},
            new Course {CourseID = 34, CourseNumber = 2, CourseName = "Pottery", CourseDescription = "Learn how to make jars out of clay"},
            new Course {CourseID = 45, CourseNumber = 3, CourseName = "Art", CourseDescription = "Beginner course on painting and drawing"},
            new Course {CourseID = 56, CourseNumber = 4, CourseName = "C#", CourseDescription = "Learn to code with C#"},
            new Course {CourseID = 78, CourseNumber = 5, CourseName = "T.V Repair", CourseDescription = "Learn how to repair Televisions"}
        };
        //private static List<Instructor> _instructors = new List<Instructor>
        //{
        //    new Instructor {InstructorID = 987, InstructorFName= "Caleb", InstructorLName = "Penman", InstructorEmail = "Caleb.Penman@school.com", Course = "Skateboarding 101"},
        //    new Instructor {InstructorID = 654, InstructorFName= "Danielle", InstructorLName = "Lafortune", InstructorEmail = "Danielle.Lafortune@school.com", Course = "Pottery"},
        //    new Instructor {InstructorID = 321, InstructorFName= "Jonathan", InstructorLName = "Campbell", InstructorEmail = "Jonny.Boy@school.com", Course = "Art"},
        //    new Instructor {InstructorID = 963, InstructorFName= "Lance", InstructorLName = "Uppercut", InstructorEmail = "Lance.Uppercut@school.com", Course = "C#"},
        //    new Instructor {InstructorID = 741, InstructorFName= "Nora", InstructorLName = "Winslo", InstructorEmail = "Nora.Winlso@school.com", Course = "T.V Repair"}
        //};
        private static List<Student> _students = new List<Student>
        {
            new Student {StudentID = 9511, StudentFName = "Elsa", StudentLName = "Hunter", StudentEmail = "SnowQueen@gmail.com", StudentPhoneNum = "250-586-9786", CourseID = 23},
            new Student {StudentID = 8522, StudentFName = "Paul", StudentLName = "Bunnian", StudentEmail = "PaulGuy@gmail.com", StudentPhoneNum = "250-778-9864", CourseID = 23},
            new Student {StudentID = 4833, StudentFName = "Homer", StudentLName = "Simpson", StudentEmail = "Donut@gmail.com", StudentPhoneNum = "897-953-2265", CourseID = 34},
            new Student {StudentID = 3564, StudentFName = "Leon", StudentLName = "Bigsby", StudentEmail = "BigBoyBigsby@gmail.com", StudentPhoneNum = "563-989-2654", CourseID = 34},
            new Student {StudentID = 3495, StudentFName = "Micheal", StudentLName = "Horner", StudentEmail = "Mike02@gmail.com", StudentPhoneNum = "250-363-6335", CourseID = 34},
            new Student {StudentID = 4536, StudentFName = "Frodo", StudentLName = "Baggins", StudentEmail = "Shire@gmail.com", StudentPhoneNum = "250-123-4566", CourseID = 45},
            new Student {StudentID = 5237, StudentFName = "Gandalf", StudentLName = "Thegrey", StudentEmail = "Wizard@gmail.com", StudentPhoneNum = "250-898-6222", CourseID = 56},
            new Student {StudentID = 6378, StudentFName = "Atlas", StudentLName = "Penman", StudentEmail = "AtlasPenDude@gmail.com", StudentPhoneNum = "453-635-5312", CourseID = 56},
            new Student {StudentID = 3349, StudentFName = "Cam", StudentLName = "Mitchell", StudentEmail = "CamCam@gmail.com", StudentPhoneNum = "250-564-8965", CourseID = 78},
            new Student {StudentID = 7470, StudentFName = "Devon", StudentLName = "Brown", StudentEmail = "DevonTheMan@gmail.com", StudentPhoneNum = "896-223-1111", CourseID = 78},
        };
        public static IEnumerable<Course> GetCourses()
        {
            return _courses;
        }
        //public static IEnumerable<Instructor> GetInstructors()
        //{
        //    return _instructors;
        //}
        public static IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}
