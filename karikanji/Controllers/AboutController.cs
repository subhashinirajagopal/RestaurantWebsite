using karikanji.DAL;
using karikanji.Models;
using karikanji.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace karikanji.Controllers
{
    public class AboutController : Controller
    {
        private readonly AboutService _aboutService;
        public AboutController()
        {           
            _aboutService = new AboutService();
        }
        public ActionResult Detail()
        {
            return View(_aboutService.GetAll().First());
        }
        public ActionResult Edit(int id = 0)
        {
            About about = _aboutService.Get(id);
            if (about == null)
            {
                return HttpNotFound();
            }
            return View(about);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(About about)
        {
            if (ModelState.IsValid)
            {
                _aboutService.Update(about);
                return RedirectToAction("Detail");
            }
            return View(about);
        }

    }
}
      
                

            