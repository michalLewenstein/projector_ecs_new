using projector_ecs_new.Core.Dto;
using projector_ecs_new.Core.Models;
using projector_ecs_new.Core.Repositories;
using projector_ecs_new.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Service
{
    public class RequestService : IRequestService
    {
        private readonly IRequestRepository _requestRepository;
        public RequestService(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }
        public List<AuthRequest> getAllRequests(int? userId)
        {
            return _requestRepository.getAllRequests(userId);
        }
        public List<AuthRequest> SearchAuthRequests(int? id , string? street , int? statusId , int? userId)
        {
            return _requestRepository.SearchAuthRequests(id ,street , statusId, userId );
        }
    }
}
