using Abp.Authorization;
using IdeasPrj.Authorization.Roles;
using IdeasPrj.Authorization.Users;

namespace IdeasPrj.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
