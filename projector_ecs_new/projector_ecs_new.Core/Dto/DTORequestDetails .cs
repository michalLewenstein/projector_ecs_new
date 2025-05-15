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
        public string? PlanNumber { get; set; }//============מספר תוכניות./תרשימים?????.????

        public string? WorkDescription { get; set; }//שדה טקסט עבור מהות העבודה

        public string? DiggingLength { get; set; }

        public string? DiggingDepth { get; set; }

        public string? DiggingWidth { get; set; }
        public string? Comments { get; set; }//שדה הערות לפרטי הבקשה


    }
}
