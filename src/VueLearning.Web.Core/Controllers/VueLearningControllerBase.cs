using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace VueLearning.Controllers
{
    public abstract class VueLearningControllerBase: AbpController
    {
        protected VueLearningControllerBase()
        {
            LocalizationSourceName = VueLearningConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
