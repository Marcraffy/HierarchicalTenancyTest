using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HierarchicalTenancyTest.EntityFrameworkCore
{
    public static class HierarchicalTenancyTestDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HierarchicalTenancyTestDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HierarchicalTenancyTestDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
