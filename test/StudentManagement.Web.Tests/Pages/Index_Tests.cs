using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace StudentManagement.Pages;

public class Index_Tests : StudentManagementWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
