using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasPrj.Ideas.Dtos
{
    [AutoMapTo(typeof(IdeasComment))]
    public class IdeasCommentInputDto:AuditedEntityDto
    {
        public string Comment { get; set; }
        public virtual int IdeaId { get; set; }
    }
}
