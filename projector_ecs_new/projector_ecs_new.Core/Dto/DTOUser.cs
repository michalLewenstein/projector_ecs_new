using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Core.Dto
{
    public class DTOUser
    {
        public int Id { get; set; }

        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? UserType { get; set; }
    }
}
