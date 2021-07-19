using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvcDemoProject.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentFName { get; set; }
        public string StudentLName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPhoneNum { get; set; }
        public int? CourseID { get; set; }
        //public Course Course { get; set; }
    }
}
