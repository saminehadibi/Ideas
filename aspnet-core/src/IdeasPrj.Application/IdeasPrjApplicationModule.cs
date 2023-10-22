using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IdeasPrj.Authorization;

namespace IdeasPrj
{
    [DependsOn(
        typeof(IdeasPrjCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class IdeasPrjApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<IdeasPrjAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(IdeasPrjApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
