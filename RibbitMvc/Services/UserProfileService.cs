using RibbitMvc.Data;
using RibbitMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RibbitMvc.Services
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IContext _context;
        private readonly IUserProfileRepository _profiles;

        public UserProfileService(IContext context)
        {
            _context = context;
            _profiles = context.Profiles;
        }

        public Models.UserProfile GetBy(int id)
        {
            return _profiles.Find(p => p.ID == id);
        }

        public void Update(ViewModel.EditProfileViewModel model)
        {
            var profile = new UserProfile() { 
                ID = model.ID,
                Bio = model.Bio,
                Email = model.Email,
                Name = model.Name,
                WebsiteUrl = model.Website
            };
            _profiles.Update(profile);
            _context.SaveChanges();
        }
    }
}