using projector_ecs_new.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Core.Dto
{
    public class DTORequestWithWorkTypes
    {
        public DTORequestDetails Request { get; set; }
        public List<AuthRequestWorkType> WorkTypes { get; set; }
    }
}
