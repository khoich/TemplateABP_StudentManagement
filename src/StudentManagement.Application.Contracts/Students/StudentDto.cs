using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace StudentManagement.Students
{
    public class StudentDto : IEntityDto<string> // Kế thừa interface bắt buộc
    {
        public string StudentCode { get; set; }   // Làm khóa chính
        public string StudentName { get; set; }
        public double GPA { get; set; }

        // Đáp ứng yêu cầu của IEntityDto<string>
        public string Id
        {
            get => StudentCode;
            set => StudentCode = value;
        }
    }
}
