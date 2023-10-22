using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using IdeasPrj.Authorization.Roles;
using IdeasPrj.Authorization.Users;
using IdeasPrj.MultiTenancy;
using IdeasPrj.Ideas;

namespace IdeasPrj.EntityFrameworkCore
{
    public class IdeasPrjDbContext : AbpZeroDbContext<Tenant, Role, User, IdeasPrjDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Idea> Ideas { get; set; }
        public virtual DbSet<IdeasComment> IdeasComments { get; set; }
        public IdeasPrjDbContext(DbContextOptions<IdeasPrjDbContext> options)
            : base(options)
        {
        }
    }
}
