using RibbitMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RibbitMvc.Data
{
    public interface IUserRepositoy : IRepository<User>
    {
        User GetBy(int id);
        User GetBy(string username);
    }
}