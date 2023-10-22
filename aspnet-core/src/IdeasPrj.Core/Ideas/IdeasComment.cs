using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasPrj.Ideas
{
    public class IdeasComment:AuditedEntity
    {
        [Required]
        [MaxLength(300)]
        public string Comment { get; set; }

        public virtual Idea Idea { get; set; }
        public virtual int IdeaId { get; set; }
    }
}
