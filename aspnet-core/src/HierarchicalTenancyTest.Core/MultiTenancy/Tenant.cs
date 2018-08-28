using Abp.MultiTenancy;
using HierarchicalTenancyTest.Authorization.Users;

namespace HierarchicalTenancyTest.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
