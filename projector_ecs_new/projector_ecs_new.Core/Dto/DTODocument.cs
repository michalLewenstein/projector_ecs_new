using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Core.Dto
{
    public class DTODocument
    {
        public int Id { get; set; }
        public string? ContentType { get; set; }//סוג הקובץ
        public string? Name { get; set; }// שם \כותרת
        public DateTime? UploadDate { get; set; }//תאריך צירוף
        public string? AddedByName { get; set; }

        //public int? IdApprover { get; set; }// נוסף ע"י
        public int? IdAuthRequest { get; set; }// מזהה בקשה
    }
}
