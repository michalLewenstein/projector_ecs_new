using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Core.Dto
{
    [Table("sys_user")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        //public int EcsIdContact { get; set; }

        //public Guid ContactGuid { get; set; }
        [Column("username")]
        public string ContactName { get; set; }

        //public string ContactTz { get; set; }

        //public string ContactPhone { get; set; }

        //public string ContactEmail { get; set; }
        [Column("password")]
        public string Passwors { get; set; }
    }
}

