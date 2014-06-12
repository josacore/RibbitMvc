using RibbitMvc.Data;
using RibbitMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RibbitMvc.Services
{
    public class RibbitService : IRibbitService
    {
        private readonly IContext _context;
        private readonly IRibbitRepository _ribbits;

        public RibbitService(IContext context)
        {
            _context = context;
            _ribbits = context.Ribbits;
        }

        public Models.Ribbit GetBy(int id)
        {
            return _ribbits.GetBy(id);
        }

        public Models.Ribbit Create(Models.User user, string status, DateTime? created = null)
        {
            var ribbit = new Ribbit()
            {
                Status = status,
                DateCreated = created.HasValue ? created.Value : DateTime.Now
            };
            _ribbits.AddFor(ribbit,user);
            _context.SaveChanges();
            return ribbit;
        }
    }
}