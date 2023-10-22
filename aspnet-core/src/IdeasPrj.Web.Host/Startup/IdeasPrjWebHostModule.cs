using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IdeasPrj.Configuration;

namespace IdeasPrj.Web.Host.Startup
{
    [DependsOn(
       typeof(IdeasPrjWebCoreModule))]
    public class IdeasPrjWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public IdeasPrjWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IdeasPrjWebHostModule).GetAssembly());
        }
    }
}
