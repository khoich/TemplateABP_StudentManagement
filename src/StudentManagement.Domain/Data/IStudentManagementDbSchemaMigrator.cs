using System.Threading.Tasks;

namespace StudentManagement.Data;

public interface IStudentManagementDbSchemaMigrator
{
    Task MigrateAsync();
}
