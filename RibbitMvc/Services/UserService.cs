using RibbitMvc.Data;
using RibbitMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace RibbitMvc.Services
{
    public class UserService : IUserService
    {
        private readonly IContext _context;
        private readonly IUserRepositoy _users;

        public UserService(IContext context)
        {
            _context = context;
            _users = context.Users;
        }

        public Models.User GetBy(int id)
        {
            return _users.GetBy(id);
        }

        public Models.User GetBy(string username)
        {
            return _users.GetBy(username);
        }

        public Models.User Create(string username, string passord, Models.UserProfile profile, DateTime? created)
        {
            var user = new User() 
            { 
                Username = username,
                Password = Crypto.HashPassword(passord),
                DateCreated = created.HasValue ? created.Value : DateTime.Now,
                Profile = profile
            };
            _users.Create(user);
            _context.SaveChanges();
            return user;
        }
    }
}