using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HierarchicalTenancyTest.Authorization.Roles;
using HierarchicalTenancyTest.Authorization.Users;
using HierarchicalTenancyTest.MultiTenancy;

namespace HierarchicalTenancyTest.EntityFrameworkCore
{
    public class HierarchicalTenancyTestDbContext : AbpZeroDbContext<Tenant, Role, User, HierarchicalTenancyTestDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HierarchicalTenancyTestDbContext(DbContextOptions<HierarchicalTenancyTestDbContext> options)
            : base(options)
        {
        }
    }
}
