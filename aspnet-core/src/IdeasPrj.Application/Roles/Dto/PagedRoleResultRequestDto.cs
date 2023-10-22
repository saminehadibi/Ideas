using Abp.Application.Services.Dto;

namespace IdeasPrj.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

