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

        public IQueryable<User> All(bool includeProfile) 
        { 
            return includeProfile ? DbSet.Include(u => u.Profile).AsQueryable() : All();
        }
        public void CreateFollower(string username, User follower)
        {
            var user = GetBy(username);
            DbSet.Attach(follower);

            user.Followers.Add(follower);
            if (!ShareContext) 
            {
                Context.SaveChanges();
            }
        }
        public void DeleteFollower(string username, User follower)
        {
            var user = GetBy(username);
            DbSet.Attach(follower);

            user.Followers.Remove(follower);
            if (!ShareContext)
            {
                Context.SaveChanges();
            }
        }
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