using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HierarchicalTenancyTest.Authorization;

namespace HierarchicalTenancyTest
{
    [DependsOn(
        typeof(HierarchicalTenancyTestCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HierarchicalTenancyTestApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HierarchicalTenancyTestAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HierarchicalTenancyTestApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
