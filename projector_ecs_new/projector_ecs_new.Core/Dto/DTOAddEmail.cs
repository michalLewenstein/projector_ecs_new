using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Core.Dto
{
    public class DTOAddEmail
    {
        public string MsgContent { get; set; }
        public List<DTOUserContact> NotifyContacts { get; set; }
        public int RequestId { get; set; }

    }
}
