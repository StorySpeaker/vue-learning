using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using VueLearning.Configuration;
using VueLearning.Web;

namespace VueLearning.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class VueLearningDbContextFactory : IDesignTimeDbContextFactory<VueLearningDbContext>
    {
        public VueLearningDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<VueLearningDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            VueLearningDbContextConfigurer.Configure(builder, configuration.GetConnectionString(VueLearningConsts.ConnectionStringName));

            return new VueLearningDbContext(builder.Options);
        }
    }
}
