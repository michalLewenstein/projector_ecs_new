﻿using projector_ecs_new.Core.Dto;
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
        private readonly EcsDbMasterContext _ecsDbMasterContext;
        public UserRepository( EcsDbMasterContext ecsDbMasterContext)
        {
            _ecsDbMasterContext = ecsDbMasterContext;
        }

        public AuthRequestContact LogIn(string email)
        {
            return  _ecsDbMasterContext.AuthRequestContacts
                .FirstOrDefault(c =>
                    (c.Email.ToLower() == email.ToLower() ||
                     c.Email.ToLower().StartsWith(email.ToLower() + "@")));

            //if (connectUser == null)
            //{
            //  var  connectStsUser = _ecsDbMasterContext.SysUsers
            //                  .FirstOrDefault(s =>
            //                 (s.Username.ToLower() == email.ToLower() ||
            //                  s.Username.ToLower().StartsWith(email.ToLower() + "@")));
            //    if (connectStsUser == null)
            //        throw new Exception("user not found");
            //    return new DTOUser
            //    {
            //        Id = connectStsUser.Id,
            //        Username = connectStsUser.Username,
            //        Password = connectStsUser.Password,
            //        FullName = connectStsUser.Fname + " " + connectStsUser.Lname,
            //        UserType = "sysuser"
            //    };
            //}
            //return new DTOUser
            //{
            //    Id = connectUser.Id,
            //    Username = connectUser.Email,
            //    Password = connectUser.CodeKey,
            //    FullName = connectUser.Fullname,
            //    UserType = "contact"
            //};

         
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
