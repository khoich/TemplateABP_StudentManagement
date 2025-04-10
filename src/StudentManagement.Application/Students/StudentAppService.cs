using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp;
using Microsoft.Extensions.Logging;

namespace StudentManagement.Students
{
    public class StudentAppService
        : CrudAppService<Student, StudentDto, string, PagedAndSortedResultRequestDto, CreateUpdateStudentDto>,
          IStudentAppService
    {
        public StudentAppService(IRepository<Student, string> repository)
            : base(repository)
        {
        }

        protected override async Task<Student> MapToEntityAsync(CreateUpdateStudentDto createInput)
        {
            // Override vì ta dùng StudentCode làm key -> không tự sinh Guid
            throw new AbpException("StudentCode is required for creation. Use CreateWithCodeAsync method instead.");
        }
            
        // Custom Create method nhận StudentCode
        public async Task<StudentDto> CreateWithCodeAsync(string studentCode, CreateUpdateStudentDto input)
        {
            var student = new Student(studentCode, input.StudentName, input.GPA);
            await Repository.InsertAsync(student, autoSave: true);
            return MapToGetOutputDto(student);
        }
    }
}
