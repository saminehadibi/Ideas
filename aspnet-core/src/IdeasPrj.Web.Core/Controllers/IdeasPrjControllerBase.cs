using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace IdeasPrj.Controllers
{
    public abstract class IdeasPrjControllerBase: AbpController
    {
        protected IdeasPrjControllerBase()
        {
            LocalizationSourceName = IdeasPrjConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
