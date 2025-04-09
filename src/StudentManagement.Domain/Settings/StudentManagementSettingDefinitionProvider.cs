using Volo.Abp.Settings;

namespace StudentManagement.Settings;

public class StudentManagementSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(StudentManagementSettings.MySetting1));
    }
}
