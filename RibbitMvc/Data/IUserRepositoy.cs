using RibbitMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RibbitMvc.Data
{
    public interface IUserRepositoy : IRepository<User>
    {
        IQueryable<User> All(bool includeProfile);
        void CreateFollower(string username, User follower);
        void DeleteFollower(string username, User follower);
        User GetBy(int id);
        User GetBy(string username);
    }
}