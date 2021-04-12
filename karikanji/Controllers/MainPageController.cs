using karikanji.DAL;
using karikanji.Models;
using karikanji.Services;
using karikanji.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace karikanji.Controllers
{
    public class MainPageController : Controller  
            
    {
        private readonly ComboService _comboService;
        private readonly MenuService _menuService;
        public MainPageController()
        {
            _comboService = new ComboService();
            _menuService = new MenuService();
        }

        public ActionResult Home()
        {
            return View(_comboService.GetComboViewModels());
        }

        #region Combo Item Edit, Add, Delete
        public ActionResult ComboItemEdit(int id = 0)
        {
            ComboItemViewModel combo = _comboService.GetViewModel(id);
            if (combo == null)
            {
                return HttpNotFound();
            }
            return View(combo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ComboItemEdit(ComboItemViewModel combo)
        {
            if (ModelState.IsValid)
            {
                _comboService.Update(combo);
                return Redirect(Url.Action("Home") + "#specialDeals");
            }
            return View(combo);
        }

        public ActionResult ComboItemDelete(int id = 0)
        {
            Combo combo = _comboService.GetModel(id);
            if (combo == null)
            {
                return HttpNotFound();
            }
            return View(combo);
        }

        [HttpPost, ActionName("ComboItemDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult ComboItemDeleteConfirmed(int id)
        {
            Combo combo = _comboService.GetModel(id);
            if (combo == null)
            {
                return HttpNotFound();
            }
            _comboService.Delete(combo);
            return Redirect(Url.Action("Home") + "#specialDeals");
        }

        public ActionResult ComboItemAdd(int id=0)
        {
            ComboItemViewModel combo = new ComboItemViewModel();
            combo.MenuId = id;
            return View(combo);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ComboItemAdd(ComboItemViewModel combo)
        {
            if (ModelState.IsValid)
            {
                _comboService.Add(combo);
                return Redirect(Url.Action("Home") + "#specialDeals");
            }
            return View(combo);
        }
        #endregion

        #region Combo Edit, Add, Delete
        public ActionResult ComboEdit(int id = 0)
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
        public ActionResult ComboEdit(Menu menu)
        {
            if (ModelState.IsValid)
            {
                _menuService.Update(menu);
                return Redirect(Url.Action("Home") + "#specialDeals");
            }
            return View(menu);
        }

        public ActionResult ComboDelete(int id = 0)
        {
            Menu menu = _menuService.Get(id);
            if (menu == null)
            {
                return HttpNotFound();
            }
            return View(menu);
        }

        [HttpPost, ActionName("ComboDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult ComboDeleteConfirmed(int id)
        {
            Menu menu = _menuService.Get(id);
            if (menu == null)
            {
                return HttpNotFound();
            }
            _menuService.Delete(menu);
            return Redirect(Url.Action("Home") + "#specialDeals");
        }

        public ActionResult ComboAdd()
        {
            Menu menu = new Menu();
            menu.MenuType = Constants.MenuType.Combo;
            return View(menu);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ComboAdd(Menu menu)
        {
            if (ModelState.IsValid)
            {
                _menuService.Add(menu);
                return Redirect(Url.Action("Home") + "#specialDeals");
            }
            return View(menu);
        }
        #endregion
    }
}     


        

  
