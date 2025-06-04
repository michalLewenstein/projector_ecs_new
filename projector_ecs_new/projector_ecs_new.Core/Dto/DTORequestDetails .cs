using projector_ecs_new.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Core.Dto
{
    public class DTORequestDetails
    {
        public int Id { get; set; }
        public int? AuthNumber { get; set; }
        public int? AuthStatusId { get; set; }
        public DateTime? AuthDate { get; set; }//תאריך בקשה
        public DateTime? LastUpdate { get; set; }//תאריך עדכון
        public DateTime? EstStartDate { get; set; }
        public DateTime? EstFinishDate { get; set; }
        public DateTime? ApprovalPlanningDate { get; set; }
        public DateTime? ApprovalWorkDate { get; set; }
        public bool? IsNightWorkAllowed { get; set; }
        public int? EstTotalDays { get; set; }
        public string? PlanNumber { get; set; }//============מספר תוכניות./תרשימים?????.????
        public string? WorkDescription { get; set; }//שדה טקסט עבור מהות העבוד
        public string? DiggingLength { get; set; }
        public string? DiggingDepth { get; set; }
        public string? DiggingWidth { get; set; }
         public int? IdWorkType { get; set; }//מזהה סוג עבודה
        public string? Comments { get; set; }//הערות
        public string ConnectedUser { get; set; }
        public AuthRequestContact AuthRequestContact { get; set; }// מגיש
        public  AuthRequestAuthority? AuthRequestAuthority { get; set; }// יזם
        public AuthRequestAuthority AuthorityWorkConstructor { get; set; }//איש קשר תיאום ביצוע
        public AuthRequestAuthority AuthorityConstructor { get; set; } // קבלן
        public AuthRequestAuthority AauthorityPlanner { get; set; } //מתכנן
        public AuthRequestAuthority AauthoritySupervisor { get; set; } //מפקח
        public List<DTOApprover>? AllApprovers { get; set; }
        public List<DTOApprover>? PlanningApprovers { get; set; }
        public List<DTOApprover>? WorkApprovers { get; set; }
        public List<DTOApprover>? FinishApprovers { get; set; }
        public List<DTODocument> Documents { get; set; }
        public List<DTOAuthRequestEngCoordMsgs> AuthRequestEngCoordMsgs { get; set; }
        public List<DTOUserContact> UserContactsList { get; set; }
        public List<DTODocumentation> DocumentationsList { get; set; }

    }
}
