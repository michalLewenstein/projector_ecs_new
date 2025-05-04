using projector_ecs_new.Core.Dto;
using projector_ecs_new.Core.Models;
using projector_ecs_new.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projector_ecs_new.Core.Repositories
{
    public interface IUserRepository
    {
        public AuthRequestContact LogIn(string email, string codeKey);
        //public void SignUp(User user);
        public List<AuthRequestContact> getAllUsers();
    }
}
