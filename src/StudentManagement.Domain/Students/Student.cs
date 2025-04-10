using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace StudentManagement.Students
{
    public class Student : Entity<string>
    {
        public string StudentName { get; set; }
        public double GPA { get; set; }

        private Student() { }

        public Student(string studentCode, string studentName, double gpa)
            : base(studentCode)
        {
            StudentName = studentName;
            GPA = gpa;
        }
    }
}
