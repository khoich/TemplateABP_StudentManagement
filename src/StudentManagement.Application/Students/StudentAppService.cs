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
using System.Runtime.InteropServices;


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

        public async Task<double> GetAverageGpaAsync()
        {
            var students = await Repository.GetListAsync();
            if (!students.Any()) return 0;

            return students.Average(x => x.GPA);
        }

    }
}
