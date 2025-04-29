using System;
using System.Collections.Generic;

namespace projector_ecs_new.Core.Models;

public partial class AuthRequestEngCoordMsg
{
    public int Id { get; set; }

    public int? IdParent { get; set; }

    public int? IdAuthRequest { get; set; }

    public string? UserType { get; set; }

    public int? IdUser { get; set; }

    public string? UserFullname { get; set; }

    public string? UserAuthorityName { get; set; }

    public int? IdMsgType { get; set; }

    public int? IdMsgStatus { get; set; }

    public string? MsgContent { get; set; }

    public DateTime? CreatedDatetime { get; set; }

    public int? IdArProcessRequest { get; set; }

    public string? MetaKeys { get; set; }
}
