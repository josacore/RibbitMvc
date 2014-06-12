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
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit()
        {
            throw new NotImplementedException();
        }
    }
}
