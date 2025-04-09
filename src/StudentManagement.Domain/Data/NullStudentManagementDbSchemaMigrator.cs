using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace StudentManagement.Data;

/* This is used if database provider does't define
 * IStudentManagementDbSchemaMigrator implementation.
 */
public class NullStudentManagementDbSchemaMigrator : IStudentManagementDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
