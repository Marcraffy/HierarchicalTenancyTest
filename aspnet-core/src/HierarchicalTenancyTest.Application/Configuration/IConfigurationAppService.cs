using System.Threading.Tasks;
using HierarchicalTenancyTest.Configuration.Dto;

namespace HierarchicalTenancyTest.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
