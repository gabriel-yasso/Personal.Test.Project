using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Personal.Test.Project.Thoughts.Dtos
{
    public class ThoughtDto : FullAuditedEntityDto<Guid>
    {
        public required string Title { get; set; }
        public required string Content { get; set; }
    }
}
