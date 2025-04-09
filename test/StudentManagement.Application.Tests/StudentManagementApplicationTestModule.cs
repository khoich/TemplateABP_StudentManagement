using Volo.Abp.Modularity;

namespace StudentManagement;

[DependsOn(
    typeof(StudentManagementApplicationModule),
    typeof(StudentManagementDomainTestModule)
    )]
public class StudentManagementApplicationTestModule : AbpModule
{

}
