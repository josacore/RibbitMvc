using RibbitMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RibbitMvc.Services
{
    public interface IRibbitService
    {
        Ribbit GetBy(int id);
        Ribbit Create(User user, string status, DateTime? created = null);
    }
}