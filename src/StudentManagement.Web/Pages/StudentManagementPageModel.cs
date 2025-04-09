using StudentManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace StudentManagement.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class StudentManagementPageModel : AbpPageModel
{
    protected StudentManagementPageModel()
    {
        LocalizationResourceType = typeof(StudentManagementResource);
    }
}
