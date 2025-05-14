using projector_ecs_new.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projector_ecs_new.Core.Dto;
using projector_ecs_new.Models;
using projector_ecs_new.Core.Models;
using Microsoft.EntityFrameworkCore;
using Azure;
using Azure.Core;

namespace projector_ecs_new.Data.Repositories
{
    public class RequestRepository : IRequestRepository
    {
    
        private readonly EcsDbMasterContext _ecsDbMasterContext;
        public RequestRepository(EcsDbMasterContext ecsDbMasterContext)
        {
            _ecsDbMasterContext = ecsDbMasterContext;
        }
        public List<AuthRequest> GetRequestsByPage(int userId, int page, int pageSize)
        {
            if (userId == null) return new List<AuthRequest>();

            var query = from ar in _ecsDbMasterContext.AuthRequests
                   join cl in _ecsDbMasterContext.AuthRequestContactsLists on ar.Id equals cl.IdAuthRequest
                   where cl.IdAuthRequestContact == userId 
                   select ar;  
            return query
                .Skip((page-1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public List<AuthRequest> SearchAuthRequests(int? number, string? street , int? statusId , int userId, int page, int pageSize)
        {
            if (userId == null) return new List<AuthRequest>();

            var query = from ar in _ecsDbMasterContext.AuthRequests
                        join cl in _ecsDbMasterContext.AuthRequestContactsLists on ar.Id equals cl.IdAuthRequest
                        where cl.IdAuthRequestContact == userId 
                        select ar;

            if (number.HasValue)
                query = query.Where(r => r.AuthNumber.ToString().Contains(number.Value.ToString()));

            if (!string.IsNullOrEmpty(street))
                query = query.Where(r => r.Street.Contains(street));

            if (statusId.HasValue)
                query = query.Where(r => r.AuthStatusId == statusId.Value);

            return query
                .Skip((page-1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public AuthRequest GetRequestById(int id)
        {
            return _ecsDbMasterContext.AuthRequests
                .FirstOrDefault(ar=> ar.Id ==  id);

        }
        public List<AuthRequestWorkType> GetWorkTypes()
        {
            return _ecsDbMasterContext.AuthRequestWorkTypes.ToList();
        }

    }
}
