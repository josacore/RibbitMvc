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
            return Create(user.ID,status,created);
        }
        public Models.Ribbit Create(int userId, string status, DateTime? created = null)
        {
            var ribbit = new Ribbit()
            {
                AuthorId = userId,
                Status = status,
                DateCreated = created.HasValue ? created.Value : DateTime.Now
            };
            _ribbits.Create(ribbit);
            _context.SaveChanges();
            return ribbit;
        }
        public IEnumerable<Ribbit> GetTimelineFor(int userId)
        {
            return _ribbits.FindAll(r => r.Author.Followers.Any( f => f.ID == userId) || 
                r.Author.ID == userId).OrderByDescending( r => r.DateCreated);
        }
    }
}