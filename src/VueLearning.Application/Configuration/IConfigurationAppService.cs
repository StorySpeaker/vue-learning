using System.Threading.Tasks;
using VueLearning.Configuration.Dto;

namespace VueLearning.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
