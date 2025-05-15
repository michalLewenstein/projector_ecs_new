using Azure;
using Azure.Core;
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
        public List<AuthRequest> GetRequestsByPage(int userId, int page, int pageSize);
        public List<AuthRequest> SearchAuthRequests(int? number, string? street, int? statusId, int userId, int page, int pageSize);
        public AuthRequest GetRequestDetailsById(int id);
        public List<AuthRequestWorkType> GetWorkTypes();
    }
}
