using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Core.Dto
{
    [Table("auth_request")]
    public class Request
    {
        [Key]
        public int Id { get; set; }
        [Column("auth_number")]
        public int? AuthNamber { get; set; }
        [Column("work_description")]
        public string? WorkDescription { get; set; }


    }
}
