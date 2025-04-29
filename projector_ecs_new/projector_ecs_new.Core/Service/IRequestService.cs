using projector_ecs_new.Core.Dto;
using projector_ecs_new.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Core.Service
{
    public interface IRequestService
    {
        public List<AuthRequest> getAllRequests();
    }
}
