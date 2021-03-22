using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VueLearning.EntityFrameworkCore;
using VueLearning.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace VueLearning.Web.Tests
{
    [DependsOn(
        typeof(VueLearningWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class VueLearningWebTestModule : AbpModule
    {
        public VueLearningWebTestModule(VueLearningEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VueLearningWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(VueLearningWebMvcModule).Assembly);
        }
    }
}