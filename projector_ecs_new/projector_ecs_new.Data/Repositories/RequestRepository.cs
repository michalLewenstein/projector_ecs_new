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

        public DTORequestDetails GetRequestDetailsById(int id)
        {
            var requestDetails = (from request in _ecsDbMasterContext.AuthRequests
                                  join authority in _ecsDbMasterContext.AuthRequestAuthorities
                                  on request.IdAuthRequestAuthorityFor equals authority.Id into authJoin
                                  from auth in authJoin.DefaultIfEmpty()
                                  where request.Id == id
                                  select new DTORequestDetails
                                  {
                                      Id = request.Id,
                                      AuthNumber = request.AuthNumber,
                                      AuthStatusId = request.AuthStatusId,
                                      AuthDate = request.AuthDate,
                                      LastUpdate = request.LastUpdate,
                                      PlanNumber = request.PlanNumber,
                                      WorkDescription = request.WorkDescription,
                                      DiggingLength = request.DiggingLength,
                                      DiggingDepth = request.DiggingDepth,
                                      DiggingWidth = request.DiggingWidth,
                                      Comments = request.Comments,
                                      IdWorkType = request.IdWorkType,
                                      IdAuthRequestAuthorityFor = request.IdAuthRequestAuthorityFor,
                                      AuthRequestAuthority = auth,

                                      // מידע על גורמים מאשרים
                                      Approvers = (from approverList in _ecsDbMasterContext.AuthRequestApproversLists
                                                       // קישור לטבלת AuthRequestApprover
                                                   join approver in _ecsDbMasterContext.AuthRequestApprovers
                                                   on approverList.IdAuthRequestApproverId equals approver.Id

                                                   // קישור לטבלת AuthRequestContact
                                                   join contact in _ecsDbMasterContext.AuthRequestContacts
                                                   on approver.IdAuthRequestContact equals contact.Id into contactJoin
                                                   from contact in contactJoin.DefaultIfEmpty()

                                                       // קישור לטבלת AuthRequestAuthority
                                                   join authority in _ecsDbMasterContext.AuthRequestAuthorities
                                                   on approver.IdAuthRequestAuthority equals authority.Id into authorityJoin
                                                   from authority in authorityJoin.DefaultIfEmpty()

                                                       // קישור לספציפי לבקשה
                                                   where approverList.IdAuthRequest == request.Id
                                                   select new DTOApprover
                                                   {
                                                       // שם מאשר (שם איש הקשר)
                                                       ContactPersonName = contact.Fullname,
                                                       // הגורם (שם הרשות)
                                                       AuthorityName = authority.AuthorityName,
                                                        // סטטוס האישור
                                                       ApprovalStatus = approverList.ConfirmStatus.ToString(),
                                                       // תאריך האישור
                                                       ApprovalDate = approverList.ConfirmDate,
                                                       // הערות
                                                       Comments = approverList.Comments,
                                                   }).OrderBy(a => a.ApprovalDate ?? DateTime.MinValue)
                                                   .ToList()
                                  }).FirstOrDefault();

            return requestDetails;
        }
        public List<AuthRequestWorkType> GetWorkTypes()
        {
            return _ecsDbMasterContext.AuthRequestWorkTypes.ToList();
        }

    }
}
