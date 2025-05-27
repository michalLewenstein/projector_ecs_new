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
using projector_ecs_new.Core.Service;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            if (userId == null) return new List<AuthRequest>();
            IQueryable<AuthRequest> query;
            //=======================================================לשנות כשיש שדה חדש האם הוא מ sysUser
            //if (IsSysUser(userId))
            //{
            //    // משתמש sysuser רואה את כל הבקשות
            //    query = _ecsDbMasterContext.AuthRequests;
            //}
            //else
            //{
            //    query = from ar in _ecsDbMasterContext.AuthRequests
            //            join cl in _ecsDbMasterContext.AuthRequestContactsLists on ar.Id equals cl.IdAuthRequest
            //            where cl.IdAuthRequestContact == userId
            //            select ar;
            //}
            query = _ecsDbMasterContext.AuthRequests;
            return query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public List<AuthRequest> SearchAuthRequests(int? number, string? street, int? statusId, int userId, int page, int pageSize)
        {
            if (userId == null) return new List<AuthRequest>();
            IQueryable<AuthRequest> query;
            //=======================================================לשנות כשיש שדה חדש האם הוא מ sysUser
            //if (IsSysUser(userId))
            //{
            //    // משתמש sysuser רואה את כל הבקשות
            //    query = _ecsDbMasterContext.AuthRequests;
            //}
            //else
            //{
            //    // משתמש רגיל רואה רק בקשות שבהן הוא מופיע כ-contact
            //    query = from ar in _ecsDbMasterContext.AuthRequests
            //            join cl in _ecsDbMasterContext.AuthRequestContactsLists on ar.Id equals cl.IdAuthRequest
            //            where cl.IdAuthRequestContact == userId
            //            select ar;
            //}
            query = _ecsDbMasterContext.AuthRequests;

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
                                      IdWorkType = request.IdWorkType,
                                      AuthRequestAuthority = auth,
                                      Documents = getDocuments(request.Id),
                                      AuthRequestEngCoordMsgs = getRequestMsgs(request.Id),
                                  }).FirstOrDefault();
            // בדיקת סוג המשתמש
            bool isAdminOrDistributor = IsAdminOrDistributerInDynamicReq(id, userId);

            if (!isAdminOrDistributor)
            {
                requestDetails.AllApprovers = new List<DTOApprover>();
                requestDetails.PlanningApprovers = new List<DTOApprover>();
                requestDetails.WorkApprovers = new List<DTOApprover>();
                requestDetails.FinishApprovers = new List<DTOApprover>();
            }
            var ar = _ecsDbMasterContext.AuthRequests.FirstOrDefault(a => a.Id == id);
            var arProcs = _ecsDbMasterContext.AuthRequestProcessRequests
                          .Where(proc => proc.IdAuthRequest == id)
                          .ToList();

            if (isAdminOrDistributor && (ar.AuthStatusId == 1 || ar.AuthStatusId == 10 || ar.AuthStatusId == 13))
            {
                requestDetails.AllApprovers = getAllApproversList(ar);
            }
            //אחרי בתקשה לתכנון
            if (ar.AuthStatusId > 1)
            {
                requestDetails.PlanningApprovers = getPlanningApproversList(ar, arProcs);
            }
            //  else if (auth_req.auth_status_id > 10 && auth_req.auth_status_id < 106 || (display_approvers_in_all_statuses && auth_req.auth_status_id >= 6 && auth_req.auth_status_id < 106))

            if ((ar.AuthStatusId > 10 && ar.AuthStatusId < 106) || (ar.AuthStatusId >= 6))
            {
                requestDetails.WorkApprovers = getWorkApproversList(ar, arProcs);
            }
            // else if ((auth_req.auth_status_id > 13 && auth_req.auth_status_id < 17) || auth_req.auth_status_id == 77 || (display_approvers_in_all_statuses && (auth_req.auth_status_id == 6 || auth_req.auth_status_id == 7)))
            if (ar.AuthStatusId > 13 || ar.AuthStatusId == 77 || (ar.AuthStatusId == 6))
            {
                requestDetails.FinishApprovers = getFinishApproversList(ar, arProcs);
            }

            return requestDetails;
        }

        public List<DTODocument> getDocuments(int requestId)
        {
            return (
                                                    from doc in _ecsDbMasterContext.Documents
                                                    where doc.IdAuthRequest == requestId
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
                                                    }).ToList();
        }

        public List<DTOAuthRequestEngCoordMsgs> getRequestMsgs(int requestId)
        {
            return (from msg in _ecsDbMasterContext.AuthRequestEngCoordMsgs
                    where msg.IdAuthRequest == requestId && msg.IdParent == null
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
                    }).ToList();
        }
        public List<DTOApprover> getAllApproversList(AuthRequest authRequest)
        {
            return (
                       from approver in _ecsDbMasterContext.AuthRequestApprovers
                       join contact in _ecsDbMasterContext.AuthRequestContacts
                       on approver.IdAuthRequestContact equals contact.Id into contactJoin
                       from contact in contactJoin.DefaultIfEmpty()
                       join authority in _ecsDbMasterContext.AuthRequestAuthorities
                       on approver.IdAuthRequestAuthority equals authority.Id into authorityJoin
                       from authority in authorityJoin.DefaultIfEmpty()
                       where approver.IsActive == true
                       select new DTOApprover
                       {
                           Id = contact.Id,
                           ContactPersonName = contact.Fullname,
                           AuthorityName = authority.AuthorityName,
                           ApprovalStatus = null,
                           ApprovalDate = null,
                           Comments = null
                       })
                       .OrderBy(a => a.ContactPersonName)
                       .ToList();
        }

        public List<DTOApprover> getPlanningApproversList(AuthRequest authRequest, List<AuthRequestProcessRequest> arpr)
        {
            var planningApproversList = new List<DTOApprover>();

            // שליפת מאשרים לפי הבקשה
            var arApList = _ecsDbMasterContext.AuthRequestApproversLists
                .Where(a => a.IdAuthRequest == authRequest.Id)
                .OrderBy(a => a.IsLast)
                .ToList();

            foreach (var arAp in arApList)
            {
                //מאשר כל הפרטים
                var approver = _ecsDbMasterContext.AuthRequestApprovers
                    .FirstOrDefault(a => a.Id == arAp.IdAuthRequestApproverId);
                //תנאים של אותו המאשר
                var approverConditions = _ecsDbMasterContext.AuthRequestApproverConditionsLists
                    .Where(c => c.IdApprover == arAp.IdAuthRequestApproverId &&
                                c.IdAuthRequest == arAp.IdAuthRequest &&
                                (c.TextType == "planning" || c.TextType == null))
                    .Join(_ecsDbMasterContext.AuthRequestConditions,
                          c => c.IdCondition,
                          cond => cond.Id,
                          (c, cond) => cond.ConditionContent)
                    .ToList();
                //הערות של המאשר
                var comments = string.IsNullOrWhiteSpace(arAp.Comments) ? "" : arAp.Comments;

                var contactPersonName = approver != null
                    ? _ecsDbMasterContext.AuthRequestContacts
                        .FirstOrDefault(c => c.Id == approver.IdAuthRequestContact)?.Fullname
                    : "איש קשר לא מזוהה";

                var authorityName = approver != null
                    ? _ecsDbMasterContext.AuthRequestAuthorities
                        .FirstOrDefault(a => a.Id == approver.IdAuthRequestAuthority)?.AuthorityName
                    : "רשות לא מזוהה";
                var dtoProcessRequest = getApproverProcs(approver.Id, arpr);

                var approverDto = new DTOApprover
                {
                    Id = arAp.Id,
                    ContactPersonName = contactPersonName,
                    AuthorityName = authorityName,
                    ApprovalStatus = arAp.ConfirmStatus,
                    ApprovalDate = arAp.ConfirmDate,
                    Comments = comments,
                    ApproverConditionText = string.Join(" ", approverConditions),
                    AuthRequestProcessRequest = dtoProcessRequest
                };

                planningApproversList.Add(approverDto);
            }

            return planningApproversList;
        }
        public List<DTOApprover> getWorkApproversList(AuthRequest authRequest, List<AuthRequestProcessRequest> arpr)
        {
            var workApproversList = new List<DTOApprover>();
            //רשימת כל המאשרי עבודה
            List<AuthRequestApproversForWorkList> arafw = (from arap in _ecsDbMasterContext.AuthRequestApproversForWorkLists
                                                           where arap.IdAuthRequest == authRequest.Id
                                                           orderby arap.IsLast
                                                           select arap).ToList();

            if (arafw != null)
            {
                // if ar is temp trans - but there is no temp trans approver is approvers list,
                // means temp trans manage/getter still did not select "add" his approvers.
                //לא נראלי צריך כי כבר הגדרתי מי יקבל את כל הרשימה של המאשרים
                //if (authRequest.IsTempTrans == true && !arafw.Any(r => r.IsTempTransApproval == true))
                //{
                //    ConnectedUser cu = get_connected_user();
                //    if ((cu.is_temp_trans_getter || cu.is_temp_trans_manager))
                //    {
                //        //get only temp trans approvers
                //        jtt_arr = get_all_approvers_list(authRequest, true);
                //    }
                //}

                foreach (AuthRequestApproversForWorkList arap in arafw)
                {
                    var approver = _ecsDbMasterContext.AuthRequestApprovers
                  .FirstOrDefault(a => a.Id == arap.IdAuthRequestApproverId);

                    var approverConditions = _ecsDbMasterContext.AuthRequestApproverConditionsLists
                   .Where(c => c.IdApprover == arap.IdAuthRequestApproverId &&
                               c.IdAuthRequest == arap.IdAuthRequest &&
                               (c.TextType == "work" || c.TextType == null))
                   .Join(_ecsDbMasterContext.AuthRequestConditions,
                         c => c.IdCondition,
                         cond => cond.Id,
                         (c, cond) => cond.ConditionContent)
                   .ToList();
                    var comments = string.IsNullOrWhiteSpace(arap.Comments) ? "" : arap.Comments;

                    var contactPersonName = approver != null
                        ? _ecsDbMasterContext.AuthRequestContacts
                            .FirstOrDefault(c => c.Id == approver.IdAuthRequestContact)?.Fullname
                        : "איש קשר לא מזוהה";

                    var authorityName = approver != null
                        ? _ecsDbMasterContext.AuthRequestAuthorities
                            .FirstOrDefault(a => a.Id == approver.IdAuthRequestAuthority)?.AuthorityName
                        : "רשות לא מזוהה";



                    var dtoProcessRequest = getApproverProcs(approver.Id, arpr);

                    var approverDto = new DTOApprover
                    {
                        Id = arap.Id,
                        ContactPersonName = contactPersonName,
                        AuthorityName = authorityName,
                        ApprovalStatus = arap.ConfirmStatus,
                        ApprovalDate = arap.ConfirmDate,
                        Comments = comments,
                        ApproverConditionText = string.Join(" ", approverConditions),
                        AuthRequestProcessRequest = dtoProcessRequest
                    };

                    workApproversList.Add(approverDto);
                }
            }
            return workApproversList;
        }
        public List<DTOApprover> getFinishApproversList(AuthRequest authRequest, List<AuthRequestProcessRequest> arpr)
        {
            var finishApproversList = new List<DTOApprover>();
            //רשימת כל המאשרי עבודה
            List<AuthRequestApproversForFinishList> araff = (from araf in _ecsDbMasterContext.AuthRequestApproversForFinishLists
                                                             where araf.IdAuthRequest == authRequest.Id
                                                             orderby araf.IsLast
                                                             select araf).ToList();
            if (araff != null)
            {
                foreach (AuthRequestApproversForFinishList araf in araff)
                {
                    var approver = _ecsDbMasterContext.AuthRequestApprovers
                  .FirstOrDefault(a => a.Id == araf.IdAuthRequestApproverId);

                    var approverConditions = _ecsDbMasterContext.AuthRequestApproverConditionsLists
                   .Where(c => c.IdApprover == araf.IdAuthRequestApproverId &&
                               c.IdAuthRequest == araf.IdAuthRequest &&
                               c.TextType == "work")
                   .Join(_ecsDbMasterContext.AuthRequestConditions,
                         c => c.IdCondition,
                         cond => cond.Id,
                         (c, cond) => cond.ConditionContent)
                   .ToList();

                    var comments = string.IsNullOrWhiteSpace(araf.Comments) ? "" : araf.Comments;

                    var contactPersonName = approver != null
                        ? _ecsDbMasterContext.AuthRequestContacts
                            .FirstOrDefault(c => c.Id == approver.IdAuthRequestContact)?.Fullname
                        : "איש קשר לא מזוהה";

                    var authorityName = approver != null
                        ? _ecsDbMasterContext.AuthRequestAuthorities
                            .FirstOrDefault(a => a.Id == approver.IdAuthRequestAuthority)?.AuthorityName
                        : "רשות לא מזוהה";

                    var dtoProcessRequest = getApproverProcs(approver.Id, arpr);

                    var approverDto = new DTOApprover
                    {
                        Id = araf.Id,
                        ContactPersonName = contactPersonName,
                        AuthorityName = authorityName,
                        ApprovalStatus = araf.ConfirmStatus,
                        ApprovalDate = araf.ConfirmDate,
                        Comments = comments,
                        ApproverConditionText = string.Join(" ", approverConditions),
                        AuthRequestProcessRequest = dtoProcessRequest
                    };

                    finishApproversList.Add(approverDto);
                }
            }
            return finishApproversList;
        }


        public List<DTOProcess> getApproverProcs(int approver_id, List<AuthRequestProcessRequest> arProcs)
        {
            var procs = new List<DTOProcess>();
            if (arProcs.Count > 0)
            {
                List<AuthRequestProcessRequest> approverProcs = (from aprProc in arProcs
                                                                 where aprProc.IdAuthRequestApproverInList == approver_id
                                                                 select aprProc).ToList();

                if (approverProcs.Count > 0)
                {
                    foreach (AuthRequestProcessRequest proc in approverProcs)
                    {
                        var newProcess = new DTOProcess
                        {
                            Id = proc.Id,
                            ProcessDescription = proc.ProcessDescription,
                            StatusContactTarget = proc.StatusContactTarget,
                            CompletedDate = proc.CompletedDate,
                            CreatedDate = proc.CreatedDate,
                            IdProcessStatus = proc.IdProcessStatus,
                        };
                        procs.Add(newProcess);
                    }
                }
            }
            //            JObject jproc = new JObject();
            //            jproc.Add("id", proc.id);

            //            jproc.Add("id_contact_created", proc.id_contact_created);
            //            jproc.Add("status_contact_created", proc.status_contact_created);

            //            if (is_external_company_system())
            //            {
            //                int id_contact = get_id_contact_of_current_system_logged(system_logged_connection_string);
            //                jproc.Add("id_authority_contact", id_contact);
            //            }

            //            jproc.Add("id_contact_target", proc.id_contact_target);
            //            jproc.Add("status_contact_target", proc.status_contact_target);

            //            jproc.Add("current_status_name", is_target_side((int)proc.id_process_status) ?
            //                                                                     proc.status_contact_target : proc.status_contact_created);

            //            jproc.Add("id_process_type", proc.id_process_type);
            //            jproc.Add("process_type_name", get_process_name_by_type_id((int)proc.id_process_type));


            //            auth_request_contact waiting_for_contact =
            //                (from c in db.auth_request_contacts
            //                 where c.id == (is_target_side((int)proc.id_process_status) ? proc.id_contact_target : proc.id_contact_created)
            //                 select c).FirstOrDefault();

            //            string waiting_for_fullname = "יוצר התהליך";

            //            if (waiting_for_contact != null)
            //            {
            //                waiting_for_fullname = waiting_for_contact.fullname;
            //            }
            //            else
            //            {
            //                sys_user waiting_for_user = (from c in db.sys_users
            //                                             where c.id == (is_target_side((int)proc.id_process_status) ? proc.id_contact_target : proc.id_contact_created)
            //                                             select c).FirstOrDefault();

            //                if (waiting_for_user != null)
            //                {
            //                    waiting_for_fullname = waiting_for_user.fname + " " + waiting_for_user.lname;
            //                }
            //                else
            //                {
            //                    auth_request_approver waiting_for_approver = (from c in db.auth_request_approvers
            //                                                                  where c.id == (is_target_side((int)proc.id_process_status) ? proc.id_contact_target : proc.id_contact_created)
            //                                                                  select c).FirstOrDefault();

            //                    if (waiting_for_approver != null)
            //                    {
            //                        auth_request_contact waiting_for_approver_contact = (from c in db.auth_request_contacts
            //                                                                             where c.id == waiting_for_approver.id_auth_request_contact
            //                                                                             select c).FirstOrDefault();

            //                        if (waiting_for_approver_contact != null)
            //                        {
            //                            waiting_for_fullname = waiting_for_approver_contact.fullname;
            //                        }
            //                    }
            //                }
            //            }

            //            jproc.Add("waiting_for_fullname", waiting_for_fullname);

            //            jproc.Add("id_auth_request", proc.id_auth_request);
            //            jproc.Add("id_auth_request_type", proc.id_auth_request_type);
            //            jproc.Add("id_process_status", proc.id_process_status);

            //            jproc.Add("process_description", proc.process_description);

            //            jproc.Add("created_date", proc.created_date != null ? proc.created_date.Value.ToShortDateString() + " " + proc.created_date.Value.ToShortTimeString() : "");
            //            jproc.Add("completed_date", proc.completed_date != null ? proc.completed_date.Value.ToShortDateString() + " " + proc.completed_date.Value.ToShortTimeString() : "");


            //            int total_msgs_count = 0;
            //            var procRootMsg = (from m in _ecsDbMasterContext.AuthRequestEngCoordMsgs
            //                                                        where m.IdArProcessRequest == proc.Id
            //                                                        select m).FirstOrDefault();
            //            if (procRootMsg != null)
            //            {
            //                if (_ecsDbMasterContext.AuthRequestEngCoordMsgs.Any(c => c.IdParent == procRootMsg.Id))
            //                {
            //                    total_msgs_count = get_childs_msgs_count(proc_root_msg.id);
            //                }
            //            }
            //            jproc.Add("total_proc_msgs", total_msgs_count);

            //            jproc.Add("id_proc_root_msg", proc_root_msg != null ? proc_root_msg.id : -1);

            //            jarr_apr_procs.Add(jproc);
            //        }

            //        return jarr_apr_procs;
            //    }

            //    return null;
            //}
            else
            {
                return null;
            }
            return procs;
        }


        public List<AuthRequestWorkType> GetWorkTypes()
        {
            return _ecsDbMasterContext.AuthRequestWorkTypes.ToList();
        }
        public bool IsAdminOrDistributerInDynamicReq(int authRequestId, int userId)
        {
            var user = _ecsDbMasterContext.AuthRequestContacts.FirstOrDefault(su => su.Id == userId);
            if (user != null)
            {
                // בדיקת משתמש מערכת
                //return user.isSys;
                //כרגע אני מחזירה לכולם כאילו הם מנהלים, כשיגיע המסד נתונים החדש לשנות את ההחזרה
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

        //public bool AddMessage(int idAuthRequest, int userId, 
        //    //string userType,
        //                        string userFullname, string userAuthorityName,
        //                        int idMsgType, string msgContent, string notifyContacts)
        //{
        //    // בדיקה בסיסית לפרמטרים
        //    if (idAuthRequest == 0 || string.IsNullOrWhiteSpace(msgContent) || string.IsNullOrWhiteSpace(notifyContacts))
        //        return false;

        //    try
        //    {
        //        // יצירת אובייקט הודעה
        //        var newMsg = new AuthRequestEngCoordMsg
        //        {
        //            IdAuthRequest = idAuthRequest,
        //            IdUser = userId,
        //            //UserType = userType,
        //            UserFullname = userFullname,
        //            UserAuthorityName = userAuthorityName,
        //            IdMsgType = idMsgType,
        //            MsgContent = msgContent,
        //            CreatedDatetime = DateTime.Now
        //        };

        //        // שמירה במסד הנתונים
        //        _ecsDbMasterContext.AuthRequestEngCoordMsgs.Add(newMsg);
        //        _ecsDbMasterContext.SaveChanges();

        //        // בניית גוף המייל
        //        string subject = $"הודעה חדשה ממערכת הבקשות (מספר בקשה {idAuthRequest})";
        //        string body = $"שלום,\n\nקיבלת הודעה חדשה מהמשתמש {userFullname} ({userAuthorityName}):\n\n\"{msgContent}\"\n\nבברכה,\nצוות המערכת";

        //        // שליחת מייל
        //        _emailService.SendEmail(notifyContacts, subject, body);

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        // ניתן גם לרשום לוג
        //        Console.WriteLine("שגיאה בשליחת מייל או שמירת הודעה: " + ex.Message);
        //        return false;
        //    }
        //}
    }

}
