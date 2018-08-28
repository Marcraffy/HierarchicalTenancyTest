using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using HierarchicalTenancyTest.Configuration;
using HierarchicalTenancyTest.Web;

namespace HierarchicalTenancyTest.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class HierarchicalTenancyTestDbContextFactory : IDesignTimeDbContextFactory<HierarchicalTenancyTestDbContext>
    {
        public HierarchicalTenancyTestDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HierarchicalTenancyTestDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            HierarchicalTenancyTestDbContextConfigurer.Configure(builder, configuration.GetConnectionString(HierarchicalTenancyTestConsts.ConnectionStringName));

            return new HierarchicalTenancyTestDbContext(builder.Options);
        }
    }
}
