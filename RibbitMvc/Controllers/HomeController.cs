using RibbitMvc.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RibbitMvc.Controllers
{
    public class HomeController : RibbitControllerBase
    {
        public HomeController() : base() {}

        public ActionResult Index()
        {
            if (!Security.IsAuthenticated) {
                return View("Landing", new LoginSignupViewModel());
            }
            var timeline = Ribbits.GetTimelineFor(Security.UserId);
            return View("Timeline",timeline);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Follow(string username)
        {
            throw new NotImplementedException(username + " followed");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Unfollow(string username)
        {
            throw new NotImplementedException(username + " unfollowed");
        }
        public ActionResult Profiles()
        {
            throw new NotImplementedException();
        }
        public ActionResult Followers()
        {
            throw new NotImplementedException();
        }
        public ActionResult Following()
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        [ChildActionOnly]
        public ActionResult Create()
        {
            return PartialView("_CreateRibbitPartial", new CreateRibbitViewModel());
        }
        [HttpPost]
        [ChildActionOnly]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateRibbitViewModel model) {
            if (ModelState.IsValid)
            {
                Ribbits.Create(Security.UserId,model.Status);
                Response.Redirect("/");
            }
            return PartialView("_CreateRibbitPartial", model);
        }
    }
}
