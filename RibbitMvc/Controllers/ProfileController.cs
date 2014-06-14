using RibbitMvc.Models;
using RibbitMvc.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RibbitMvc.Controllers
{
    public class ProfileController : RibbitControllerBase
    {
        public ActionResult Index()
        {
            if (!Security.IsAuthenticated)
            {
                return RedirectToAction("index", "home");
            }
            UserProfile profile = Profiles.GetBy(CurrentUser.UserProfileId);
            return View(new EditProfileViewModel() 
            {
                Bio = profile.Bio,
                Email = profile.Email,
                ID = profile.ID,
                Name = profile.Name,
                Website = profile.WebsiteUrl,
                EmailHash = profile.GetEmailHash(),
            });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditProfileViewModel model)
        {
            if(!Security.IsAuthenticated)
            {
                return RedirectToAction("index","home");
            }
            if(!ModelState.IsValid)
            {
                return View("index", model);
            }
            Profiles.Update(model);
            return RedirectToAction("Index");
        }
    }
}
