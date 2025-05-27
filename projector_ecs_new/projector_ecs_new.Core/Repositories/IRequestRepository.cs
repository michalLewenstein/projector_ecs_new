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
        public DTORequestDetails GetRequestDetailsById(int id, int userId);
        public List<AuthRequestWorkType> GetWorkTypes();
        //public bool AddMessage(string idAuthRequest, string userId, string userType,
        //                                string userFullname, string userAuthorityName,
        //                                string idMsgType, string msgContent, string notifyContacts);
    }
}
