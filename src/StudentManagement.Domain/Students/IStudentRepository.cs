using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace StudentManagement.Students
{
    public interface IStudentRepository : IRepository<Student, string>
    {
        // Nếu có custom method thì bổ sung sau
    }
}
