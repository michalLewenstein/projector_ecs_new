using projector_ecs_new.Core.Dto;
using projector_ecs_new.Core.Models;
using projector_ecs_new.Core.Repositories;
using projector_ecs_new.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        //private readonly DataContext _context;
        private readonly EcsDbMasterContext _ecsDbMasterContext;
        public UserRepository( EcsDbMasterContext ecsDbMasterContext)
        {
           // _context = context;
            _ecsDbMasterContext = ecsDbMasterContext;
        }

        public void LogIn(AuthRequestContact user)
        {
            var contactUser = (from c in _ecsDbMasterContext.AuthRequestContacts
                               where c.Email.ToLower().Contains(user.Email.ToLower()) && c.CodeKey == user.CodeKey
                               select c).FirstOrDefault();
            if (contactUser == null)
            {
                throw new Exception("user not exists or password is uncorrect!");
            }

        }


        //public void SignUp(AuthRequestContact user)
        //{
        //    var existingUser = _context.Users
        // .FirstOrDefault(g => g.ContactName == user.ContactName);
        //    if (existingUser != null)
        //    {
        //        throw new Exception("user already exists!");
        //    }
        //    _context.Users.Add(user);
        //    _context.SaveChanges();
        //}
        public List<AuthRequestContact> getAllUsers()
        {
            return _ecsDbMasterContext.AuthRequestContacts.ToList();
        }
    }
}
