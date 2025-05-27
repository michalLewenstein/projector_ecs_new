using projector_ecs_new.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Core.Dto
{
    public class DTOApprover
    {
        public int Id { get; set; }

        public string? ContactPersonName { get; set; }         // איש קשר (מהטבלה של contacts)
        public string? AuthorityName { get; set; }             // שם הרשות (מהטבלה של authorities)
        public int? ApprovalStatus { get; set; }            // סטטוס אישור
        public DateTime? ApprovalDate { get; set; }            // תאריך אישור
        public string? Comments { get; set; }                  // הערות
        public bool AlreadySendPost { get; set; }       //=================================מה השדה הזה?
        public bool ApproverLoad { get; set; }
        public bool IsAuthReqSent { get; set; } 
        public string? ApproverConditionText { get; set; }
        public List<DTOProcess>? AuthRequestProcessRequest { get; set; }
    }
}
