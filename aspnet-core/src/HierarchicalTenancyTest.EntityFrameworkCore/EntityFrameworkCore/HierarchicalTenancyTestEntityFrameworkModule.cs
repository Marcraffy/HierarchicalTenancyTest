using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using HierarchicalTenancyTest.EntityFrameworkCore.Seed;

namespace HierarchicalTenancyTest.EntityFrameworkCore
{
    [DependsOn(
        typeof(HierarchicalTenancyTestCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class HierarchicalTenancyTestEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<HierarchicalTenancyTestDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        HierarchicalTenancyTestDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        HierarchicalTenancyTestDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HierarchicalTenancyTestEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
