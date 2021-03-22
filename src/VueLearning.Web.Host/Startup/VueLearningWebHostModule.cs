using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VueLearning.Configuration;

namespace VueLearning.Web.Host.Startup
{
    [DependsOn(
       typeof(VueLearningWebCoreModule))]
    public class VueLearningWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public VueLearningWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VueLearningWebHostModule).GetAssembly());
        }
    }
}
