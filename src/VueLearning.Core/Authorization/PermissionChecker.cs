using Abp.Authorization;
using VueLearning.Authorization.Roles;
using VueLearning.Authorization.Users;

namespace VueLearning.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
