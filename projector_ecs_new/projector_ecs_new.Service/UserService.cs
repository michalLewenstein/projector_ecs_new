using projector_ecs_new.Core.Dto;
using projector_ecs_new.Core.Models;
using projector_ecs_new.Core.Repositories;
using projector_ecs_new.Core.Service;
using projector_ecs_new.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _useRepository;
        public UserService(IUserRepository useRepository)
        {
            _useRepository = useRepository;
        }
        public AuthRequestContact LogIn(string email)
        {
            var existingUser = _useRepository.LogIn(email);
            if (existingUser == null)
                throw new Exception("user not exists or password is incorrect!");

            return existingUser;
        }
        //public void SignUp(User user)
        //{
        //   _useRepository.SignUp(user);
        //}
        public List<AuthRequestContact> getAllUsers()
        {
            return _useRepository.getAllUsers();
        }
    }
}
