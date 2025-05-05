using projector_ecs_new.Core.Dto;
using projector_ecs_new.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Core.Repositories
{
    public interface IRequestRepository
    {
        public List<AuthRequest> getAllRequests(int? userId);
        public List<AuthRequest> SearchAuthRequests(int? number, string? street, int? statusId,int? userId);
    }
}
