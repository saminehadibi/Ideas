using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasPrj.Ideas.Dtos
{
    [AutoMapFrom(typeof(IdeasComment))]
    public class IdeasCommentOutputDto : AuditedEntityDto
    {
        public string Comment { get; set; }
        public virtual int IdeaId { get; set; }
    }
}
