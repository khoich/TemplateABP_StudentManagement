using StudentManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace StudentManagement.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StudentManagementController : AbpControllerBase
{
    protected StudentManagementController()
    {
        LocalizationResource = typeof(StudentManagementResource);
    }
}
