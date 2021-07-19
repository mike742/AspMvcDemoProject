using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvcDemoProject.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public int CourseNumber { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
    }
}
