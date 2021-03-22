using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace VueLearning.EntityFrameworkCore
{
    public static class VueLearningDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<VueLearningDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<VueLearningDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
