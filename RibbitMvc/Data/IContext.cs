using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RibbitMvc.Data
{
    public interface IContext : IDisposable
    {
        IUserRepositoy Users { get; }
        IRibbitRepository Ribbits { get; }

        int SaveChanges();
    }
}