using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Core.Dto
{
    public class DTOProcess
    {
        public int Id { get; set; }
        public string? ProcessDescription { get; set; }
        public string? StatusContactTarget { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int? IdProcessStatus { get; set; }
    }
}
