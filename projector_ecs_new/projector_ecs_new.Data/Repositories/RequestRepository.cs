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

namespace projector_ecs_new.Data.Repositories
{
    public class RequestRepository : IRequestRepository
    {
    
        private readonly EcsDbMasterContext _ecsDbMasterContext;
        public RequestRepository(EcsDbMasterContext ecsDbMasterContext)
        {
            _ecsDbMasterContext = ecsDbMasterContext;
        }
        public List<AuthRequest> getAllRequests(int? userId)
        {
            Console.WriteLine("המשתמש שאני מחפשת לו בקשות", userId);
            return (from ar in _ecsDbMasterContext.AuthRequests
                   join cl in _ecsDbMasterContext.AuthRequestContactsLists on ar.Id equals cl.IdAuthRequest
                   where cl.IdAuthRequestContact == userId // סינון לפי המשתמש
                   select ar).ToList();  
        }

        public List<AuthRequest> SearchAuthRequests(int? id , string? street , int? statusId , int? userId)
        {
            var query = from ar in _ecsDbMasterContext.AuthRequests
                        join cl in _ecsDbMasterContext.AuthRequestContactsLists on ar.Id equals cl.IdAuthRequest
                        where cl.IdAuthRequestContact == userId // סינון לפי המשתמש
                        select ar;

            if (id.HasValue)
                query = query.Where(r => r.Id == id.Value);

            if (!string.IsNullOrEmpty(street))
                query = query.Where(r => r.Street.Contains(street));

            if (statusId.HasValue)
                query = query.Where(r => r.AuthStatusId == statusId.Value);

            return query.ToList();
        }

    }
}
//לקבל פרמטר של משתמש בצד שרת מחובר למערכת
//לקבל פרמטרים של מזהה בקשה כתובת וסטטוס.
//שאילתה שמקבלת בקשות לפי הפרמטרים שהועברו והמשתמש המחובר מופיע בטבלת auth_request_contact_list

