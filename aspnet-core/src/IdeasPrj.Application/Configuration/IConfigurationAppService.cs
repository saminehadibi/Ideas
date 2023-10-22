using System.Threading.Tasks;
using IdeasPrj.Configuration.Dto;

namespace IdeasPrj.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
