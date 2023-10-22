using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasPrj.Ideas.Dtos
{
    [AutoMapFrom(typeof(Idea))]
    public class IdeaOutputDto: AuditedEntityDto
    {
        public string Title { get; set; }
        public string IdeaText { get; set; }
    }
}
