using System.Threading.Tasks;
using Abp.Application.Services;
using IdeasPrj.Sessions.Dto;

namespace IdeasPrj.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
