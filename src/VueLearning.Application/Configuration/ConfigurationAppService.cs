using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using VueLearning.Configuration.Dto;

namespace VueLearning.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : VueLearningAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
