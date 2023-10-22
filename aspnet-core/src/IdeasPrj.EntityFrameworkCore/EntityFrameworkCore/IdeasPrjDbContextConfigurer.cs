using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace IdeasPrj.EntityFrameworkCore
{
    public static class IdeasPrjDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<IdeasPrjDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<IdeasPrjDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
