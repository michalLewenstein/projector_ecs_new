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
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public List<AuthRequest> SearchAuthRequests(int? number, string? street, int? statusId, int userId, int page, int pageSize)
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
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
        public DTORequestDetails GetRequestDetailsById(int id, int userId)
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
                                      AuthRequestAuthority = auth,

                                    

                                      Documents = (
                                                    from doc in _ecsDbMasterContext.Documents
                                                    where doc.IdAuthRequest == request.Id
                                                    select new DTODocument
                                                    {
                                                        Id = doc.Id,
                                                        ContentType = doc.ContentType,
                                                        Name = doc.Name,
                                                        UploadDate = doc.UploadDate,
                                                        IdAuthRequest = doc.IdAuthRequest,
                                                        AddedByName =
                                                            doc.TypeApprover == "contact" ?
                                                                _ecsDbMasterContext.AuthRequestContacts
                                                                    .Where(c => c.Id == doc.IdApprover)
                                                                    .Select(c => c.Fullname)
                                                                    .FirstOrDefault()
                                                            : doc.TypeApprover == "sysuser" ?
                                                                _ecsDbMasterContext.SysUsers
                                                                    .Where(u => u.Id == doc.IdApprover)
                                                                    .Select(u => u.Fname + " " + u.Lname)
                                                                    .FirstOrDefault()
                                                                ?? _ecsDbMasterContext.AuthRequestApprovers
                                                                    .Where(a => a.Id == doc.IdApprover)
                                                                    .Join(_ecsDbMasterContext.AuthRequestContacts,
                                                                          a => a.IdAuthRequestContact,
                                                                          c => c.Id,
                                                                          (a, c) => c.Fullname)
                                                                    .FirstOrDefault()
                                                            : doc.TypeApprover == "approver" ?
                                                                _ecsDbMasterContext.AuthRequestApprovers
                                                                    .Where(a => a.Id == doc.IdApprover)
                                                                    .Join(_ecsDbMasterContext.AuthRequestContacts,
                                                                          a => a.IdAuthRequestContact,
                                                                          c => c.Id,
                                                                          (a, c) => c.Fullname)
                                                                    .FirstOrDefault()
                                                            : doc.TypeApprover == "entity" ?
                                                                _ecsDbMasterContext.AuthRequestEntities
                                                                    .Where(e => e.Id == doc.IdApprover)
                                                                    .Join(_ecsDbMasterContext.AuthRequestContacts,
                                                                          e => e.IdAuthRequestContact,
                                                                          c => c.Id,
                                                                          (e, c) => c.Fullname)
                                                                    .FirstOrDefault()
                                                                ?? _ecsDbMasterContext.AuthRequestApprovers
                                                                    .Where(a => a.Id == doc.IdApprover)
                                                                    .Join(_ecsDbMasterContext.AuthRequestContacts,
                                                                          a => a.IdAuthRequestContact,
                                                                          c => c.Id,
                                                                          (a, c) => c.Fullname)
                                                                    .FirstOrDefault()
                                                            : ""
                                                    }).ToList(),
                                      AuthRequestEngCoordMsgs = (from msg in _ecsDbMasterContext.AuthRequestEngCoordMsgs
                                                                 where msg.IdAuthRequest == id && msg.IdParent == null
                                                                 orderby msg.CreatedDatetime descending
                                                                 select new DTOAuthRequestEngCoordMsgs
                                                                 {
                                                                     Id = msg.Id,
                                                                     UserType = msg.UserType,
                                                                     IdUser = msg.IdUser,
                                                                     UserFullname = msg.UserFullname,
                                                                     UserAuthorityName = msg.UserAuthorityName,
                                                                     IdMsgStatus = msg.IdMsgStatus,
                                                                     MsgContent = msg.MsgContent,
                                                                     CreatedDatetime = msg.CreatedDatetime
                                                                 }).ToList()
                                                                 })
                                                               .FirstOrDefault();
            // בדיקת סוג המשתמש
            bool isAdminOrDistributor = IsAdminOrDistributerInDynamicReq(id, userId);

            if (!isAdminOrDistributor)
            {
                // משתמש רגיל – מחזירים רשימה ריקה
                requestDetails.Approvers = new List<DTOApprover>();
            }
            else
            {
                if (requestDetails.AuthStatusId <= 1)
                {
                    // בקשה בסטטוס ראשוני – מחזירים את כל המאשרים האפשריים
                    requestDetails.Approvers = (from approverList in _ecsDbMasterContext.AuthRequestApproversLists
                                                join approver in _ecsDbMasterContext.AuthRequestApprovers
                                                on approverList.IdAuthRequestApproverId equals approver.Id
                                                join contact in _ecsDbMasterContext.AuthRequestContacts
                                                on approver.IdAuthRequestContact equals contact.Id into contactJoin
                                                from contact in contactJoin.DefaultIfEmpty()
                                                join authority in _ecsDbMasterContext.AuthRequestAuthorities
                                                on approver.IdAuthRequestAuthority equals authority.Id into authorityJoin
                                                from authority in authorityJoin.DefaultIfEmpty()
                                                select new DTOApprover
                                                {
                                                    Id = contact.Id,
                                                    ContactPersonName = contact.Fullname,
                                                    AuthorityName = authority.AuthorityName,
                                                    ApprovalStatus = approverList.ConfirmStatus.ToString(),
                                                    ApprovalDate = approverList.ConfirmDate,
                                                    Comments = approverList.Comments,
                                                })
                                                    .OrderBy(a => a.ApprovalDate ?? DateTime.MinValue)
                                                    .ToList();
                }
                else
                {
                    // בקשה מתקדמת – מחזירים את המאשרים בפועל
                    requestDetails.Approvers = (from approverList in _ecsDbMasterContext.AuthRequestApproversLists
                                                join approver in _ecsDbMasterContext.AuthRequestApprovers
                                                on approverList.IdAuthRequestApproverId equals approver.Id
                                                join contact in _ecsDbMasterContext.AuthRequestContacts
                                                on approver.IdAuthRequestContact equals contact.Id into contactJoin
                                                from contact in contactJoin.DefaultIfEmpty()
                                                join authority in _ecsDbMasterContext.AuthRequestAuthorities
                                                on approver.IdAuthRequestAuthority equals authority.Id into authorityJoin
                                                from authority in authorityJoin.DefaultIfEmpty()
                                                where approverList.IdAuthRequest == id
                                                select new DTOApprover
                                                {
                                                    Id = contact.Id,
                                                    ContactPersonName = contact.Fullname,
                                                    AuthorityName = authority.AuthorityName,
                                                    ApprovalStatus = approverList.ConfirmStatus.ToString(),
                                                    ApprovalDate = approverList.ConfirmDate,
                                                    Comments = approverList.Comments,
                                                })
                                                    .OrderBy(a => a.ApprovalDate ?? DateTime.MinValue)
                                                    .ToList();
                }
            }
            return requestDetails;
        }
        public List<AuthRequestWorkType> GetWorkTypes()
        {
            return _ecsDbMasterContext.AuthRequestWorkTypes.ToList();
        }
        public bool IsAdminOrDistributerInDynamicReq(int authRequestId, int userId)
        {
           var user = _ecsDbMasterContext.SysUsers.FirstOrDefault(su => su.Id == userId);
            if(user != null) {
                // בדיקת משתמש מערכת
                if (userId != -1 && user.GetType().Equals("sysuser"))
                    return true;
            }
            // שליפת סוג הבקשה הדינמית
            var authRequest = _ecsDbMasterContext.AuthRequests
                                .FirstOrDefault(a => a.Id == authRequestId);

            if (authRequest == null || authRequest.IdDynamicReqType == null)
                return false;

            int dynamicReqTypeId = authRequest.IdDynamicReqType.Value;

            // בדיקה אם המשתמש הוא מנהל או מפיץ עבור סוג הבקשה
            bool isManagerOrDistributer = _ecsDbMasterContext.DynamicRequestContacts
                .Any(c =>
                    c.IdRequestType == dynamicReqTypeId &&
                    c.IdContact == userId &&
                    (c.IsRequestsManager == true || c.IsDistributeRequests == true)
                );

            return isManagerOrDistributer;
        }
    }
}
