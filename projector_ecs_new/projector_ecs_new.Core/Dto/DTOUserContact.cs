using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Core.Dto
{
    public class DTOUserContact
    {
        public int Id { get; set; }

        public string? Email { get; set; }

        public string? Fullname { get; set; }

        public string? Phone { get; set; }
    }
}
