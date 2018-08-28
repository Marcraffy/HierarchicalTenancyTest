using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HierarchicalTenancyTest.Configuration;
using HierarchicalTenancyTest.EntityFrameworkCore;
using HierarchicalTenancyTest.Migrator.DependencyInjection;

namespace HierarchicalTenancyTest.Migrator
{
    [DependsOn(typeof(HierarchicalTenancyTestEntityFrameworkModule))]
    public class HierarchicalTenancyTestMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public HierarchicalTenancyTestMigratorModule(HierarchicalTenancyTestEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(HierarchicalTenancyTestMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                HierarchicalTenancyTestConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HierarchicalTenancyTestMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
