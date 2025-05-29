using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Core.Dto
{
    public class DTOAuthRequestEngCoordMsgs
    {
        public int Id { get; set; }
        public string? UserType { get; set; }

        public int? IdUser { get; set; }

        public string? UserFullname { get; set; }

        public string? UserAuthorityName { get; set; }
        public int? IdMsgStatus { get; set; }

        public string? MsgContent { get; set; }
        public DateTime? CreatedDatetime { get; set; }
    }
}
