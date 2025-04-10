using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace StudentManagement.Students
{
    public interface IStudentAppService :
        ICrudAppService<
            StudentDto,
            string,
            PagedAndSortedResultRequestDto,
            CreateUpdateStudentDto>
    {
    }
}
