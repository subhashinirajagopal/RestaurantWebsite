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
    public class MenuController : Controller
    {
        private readonly MenuService _menuService;
        public MenuController()             
        {    
           _menuService = new MenuService();

        }
        public ActionResult Detail()
        {

            return View(_menuService.GetMenuList());
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Menu menu)
        {
            if (ModelState.IsValid)
            {
                _menuService.Add(menu);
                return RedirectToAction("Detail");
            }
            return View(menu);
        
        }
        public ActionResult Edit(int id = 0)
        {
            Menu menu = _menuService.Get(id);
            if (menu == null)
            {
                return HttpNotFound();
            }
            return View(menu);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Menu menu)
        {
            if (ModelState.IsValid)
            {
                _menuService.Update(menu);
                return RedirectToAction("Detail");
            }
            return View(menu);
        }
        public ActionResult Delete(int id)
        {
            Menu menu = _menuService.Get(id);
            if (menu == null)
            {
                return HttpNotFound();
            }
            return View(menu);        
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Menu menu = _menuService.Get(id);
            if (menu == null)
            {
                return HttpNotFound();
            }
            _menuService.Delete(menu);
            return RedirectToAction("Detail");
        }            

    }
}
