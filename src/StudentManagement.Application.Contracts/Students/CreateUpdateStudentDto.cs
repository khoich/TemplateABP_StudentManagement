using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Students
{
    public class CreateUpdateStudentDto
    {
        [Required]
        public string StudentCode { get; set; }

        [Required]
        public string StudentName { get; set; }

        [Range(0, 10)]
        public double GPA { get; set; }
    }
}
