using System;
using System.Collections.Generic;
using System.Text;
using StudentManagement.Localization;
using Volo.Abp.Application.Services;

namespace StudentManagement;

/* Inherit your application services from this class.
 */
public abstract class StudentManagementAppService : ApplicationService
{
    protected StudentManagementAppService()
    {
        LocalizationResource = typeof(StudentManagementResource);
    }
}
