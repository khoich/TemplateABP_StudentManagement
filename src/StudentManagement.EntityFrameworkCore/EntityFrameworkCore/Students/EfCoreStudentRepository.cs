using StudentManagement.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace StudentManagement.EntityFrameworkCore.Students
{
    public class EfCoreStudentRepository
        : EfCoreRepository<StudentManagementDbContext, Student, string>,
          IStudentRepository
    {
        public EfCoreStudentRepository(
            IDbContextProvider<StudentManagementDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Add custom query methods if needed
    }
}
