using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VueLearning.Authorization;

namespace VueLearning
{
    [DependsOn(
        typeof(VueLearningCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class VueLearningApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<VueLearningAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(VueLearningApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
