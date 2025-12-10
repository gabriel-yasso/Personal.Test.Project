using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Personal.Test.Project.Thoughts
{
    public class Thought : FullAuditedEntity<Guid>
    {
        public required string Title { get; set; }
        public required string Content { get; set; }
        protected Thought()
        {
        }
        [SetsRequiredMembers]
        public Thought(Guid id, string content, string title) : base(id)
        {
            Content = content;
            Title = title;
        }
    }
}
