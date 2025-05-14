using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Core.Dto
{
    public class DTORequest
    {
        public int Id { get; set; }
        public int? AuthNumber { get; set; }
        public string? Street { get; set; }
        public string? ContactPersonName { get; set; }
        public string? ToAuthorityName { get; set; }
        public int? AuthStatusId { get; set; }
        public DateTime? AuthDatePlanning { get; set; }
        
        

    }
}
