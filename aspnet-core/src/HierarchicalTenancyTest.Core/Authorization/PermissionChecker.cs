using Abp.Authorization;
using HierarchicalTenancyTest.Authorization.Roles;
using HierarchicalTenancyTest.Authorization.Users;

namespace HierarchicalTenancyTest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
