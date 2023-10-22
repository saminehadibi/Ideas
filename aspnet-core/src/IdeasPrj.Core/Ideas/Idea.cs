using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasPrj.Ideas
{
    public class Idea: AuditedEntity
    {
        [Required]
        [MaxLength(20)]
        public string Title { get; set; }

        [Required]
        [MaxLength(400)]
        public string IdeaText { get; set; }
    }
}
