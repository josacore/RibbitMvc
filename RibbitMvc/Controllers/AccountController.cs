using RibbitMvc.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RibbitMvc.Controllers
{
    public class AccountController : RibbitControllerBase
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(SignupViewModel model) 
        {
            if (Security.IsAuthenticated) {
                return RedirectToAction("Index","Home");
            }
            if (!ModelState.IsValid) {
                return View("Landing",model);
            }
            if (Security.DoesUserExist(model.Username)) {
                ModelState.AddModelError("Username", "Username is already taken.");
                return View("Landing", model);
            }
            Security.CreateUser(model);
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login()
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logout()
        {
            Security.Logout();
            throw new NotImplementedException();
        }
    }
}