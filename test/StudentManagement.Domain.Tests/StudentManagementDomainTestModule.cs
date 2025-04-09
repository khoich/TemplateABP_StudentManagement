using StudentManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace StudentManagement;

[DependsOn(
    typeof(StudentManagementEntityFrameworkCoreTestModule)
    )]
public class StudentManagementDomainTestModule : AbpModule
{

}
