using Azure;
using Azure.Core;
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
        public List<AuthRequest> GetRequestsByPage(int userId, int page, int pageSize)
        {
            return _requestRepository.GetRequestsByPage(userId, page, pageSize);
        }
        public List<AuthRequest> SearchAuthRequests(int? number, string? street, int? statusId, int userId, int page, int pageSize)
        {
            return _requestRepository.SearchAuthRequests(number, street, statusId, userId, page, pageSize);
        }
        public DTORequestDetails GetRequestDetailsById(int id, int userId)
        {
            return _requestRepository.GetRequestDetailsById(id, userId);
        }
        public List<AuthRequestWorkType> GetWorkTypes()
        {
            return _requestRepository.GetWorkTypes();
        }
        //public bool AddMessage(string idAuthRequest, string userId, string userType,
        //                                string userFullname, string userAuthorityName,
        //                                string idMsgType, string msgContent, string notifyContacts)
        //{
        //    return _requestRepository.AddMessage( idAuthRequest,  userId,  userType,
        //                                 userFullname,  userAuthorityName,
        //                                 idMsgType,  msgContent,  notifyContacts);
        //}
    }
}
