using AutoMapper;
using projector_ecs_new.Core.Models;
using projector_ecs_new.Models;

namespace projector_ecs_new.Mapping
{
    public class MappingLoginUser : Profile
    {
        public MappingLoginUser() {
            CreateMap<UserLogin, User>();
        }
    }
}
