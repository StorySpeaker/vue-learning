using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using VueLearning.Authorization.Roles;
using VueLearning.Authorization.Users;
using VueLearning.MultiTenancy;

namespace VueLearning.EntityFrameworkCore
{
    public class VueLearningDbContext : AbpZeroDbContext<Tenant, Role, User, VueLearningDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public VueLearningDbContext(DbContextOptions<VueLearningDbContext> options)
            : base(options)
        {
        }
    }
}
