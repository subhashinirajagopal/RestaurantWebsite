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
    public class ContactController : Controller
    {
        private readonly ContactService _contactService;
         public ContactController()               
         {  
           _contactService = new ContactService();
         }
        public ActionResult Detail()
        {

            return View(_contactService.GetAll());
        }
        
        public ActionResult Edit(int id = 0)
        {
            Contact contact = _contactService.Get(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _contactService.Update(contact);
                return RedirectToAction("Detail");
            }
            return View(contact);
        }       
      }
}
