using projector_ecs_new.Core.Models;
using projector_ecs_new.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public void LogIn(User user)
        {
            var existingGrocer = _context.Users
             .FirstOrDefault(g => g.ContactName == user.ContactName);
            if (existingGrocer == null)
            {
                throw new Exception("grocer not exists!");
            }
            var cheackGrocer = _context.Users.FirstOrDefault(s => s.ContactPhone.Equals(existingGrocer.ContactPhone));
            if (cheackGrocer == null)
            {
                throw new Exception("the phon is uncorrect!");
            }
        }
        public void SignUp(User user)
        {
            var existingUser = _context.Users
         .FirstOrDefault(g => g.ContactName == user.ContactName);
            if (existingUser != null)
            {
                throw new Exception("user already exists!");
            }
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public List<User> getAllUsers()
        {
            return _context.Users.ToList();
        }
    }
}
