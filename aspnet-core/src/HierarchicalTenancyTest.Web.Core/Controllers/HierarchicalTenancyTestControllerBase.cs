using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HierarchicalTenancyTest.Controllers
{
    public abstract class HierarchicalTenancyTestControllerBase: AbpController
    {
        protected HierarchicalTenancyTestControllerBase()
        {
            LocalizationSourceName = HierarchicalTenancyTestConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
