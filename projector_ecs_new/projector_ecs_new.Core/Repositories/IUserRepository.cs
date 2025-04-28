using projector_ecs_new.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Core.Repositories
{
    public interface IUserRepository
    {
        public void LogIn(User user);
        public void SignUp(User user);
        public List<User> getAllUsers();
    }
}
