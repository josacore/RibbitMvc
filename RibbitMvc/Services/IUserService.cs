using RibbitMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RibbitMvc.Services
{
    public interface IUserService
    {
        User GetBy(int id);
        User GetBy(string username);
        User Create(string username, string passord, UserProfile profile, DateTime? created);
    }
}