using Abp.Application.Services;
using IdeasPrj.MultiTenancy.Dto;

namespace IdeasPrj.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

