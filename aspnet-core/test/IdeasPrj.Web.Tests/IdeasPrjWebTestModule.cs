using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IdeasPrj.EntityFrameworkCore;
using IdeasPrj.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace IdeasPrj.Web.Tests
{
    [DependsOn(
        typeof(IdeasPrjWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class IdeasPrjWebTestModule : AbpModule
    {
        public IdeasPrjWebTestModule(IdeasPrjEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IdeasPrjWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(IdeasPrjWebMvcModule).Assembly);
        }
    }
}