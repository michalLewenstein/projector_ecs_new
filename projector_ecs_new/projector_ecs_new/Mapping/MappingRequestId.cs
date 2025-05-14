using AutoMapper;
using projector_ecs_new.Core.Dto;
using projector_ecs_new.Core.Models;

namespace projector_ecs_new.Mapping
{
    public class MappingRequestId : Profile
    {
        public MappingRequestId() {
            CreateMap<AuthRequest, DTORequestId>();
        }
    }
}
