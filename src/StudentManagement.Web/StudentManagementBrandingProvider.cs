using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace StudentManagement.Web;

[Dependency(ReplaceServices = true)]
public class StudentManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "StudentManagement";
}
