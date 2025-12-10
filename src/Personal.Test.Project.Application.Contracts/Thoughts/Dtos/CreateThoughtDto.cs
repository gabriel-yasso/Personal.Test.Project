using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Test.Project.Thoughts.Dtos
{
    public class CreateThoughtDto
    {
        public required string Title { get; set; }
        public required string Content { get; set; }
    }
}
