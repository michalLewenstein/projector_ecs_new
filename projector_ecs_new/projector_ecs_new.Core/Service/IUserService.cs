using projector_ecs_new.Core.Dto;
using projector_ecs_new.Core.Models;
using projector_ecs_new.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Core.Service
{
    public interface IUserService
    {
        public AuthRequestContact LogIn(AuthRequestContact user);
        //public void SignUp(AuthRequestContact user);
        public List<AuthRequestContact> getAllUsers();
    }
}
