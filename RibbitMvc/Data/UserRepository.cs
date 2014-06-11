using RibbitMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RibbitMvc.Data
{
    public class UserRepository : EfRepository<User>, IUserRepositoy
    {
        public UserRepository(DbContext context,bool sharedContext) : base(context,sharedContext) { }

        public User GetBy(int id)
        {
            return Find( u => u.ID == id);
        }

        public User GetBy(string username)
        {
            return Find(u => u.Username == username);
        }
    }
}