using StudentManagement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace StudentManagement.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(StudentManagementEntityFrameworkCoreModule),
    typeof(StudentManagementApplicationContractsModule)
    )]
public class StudentManagementDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
