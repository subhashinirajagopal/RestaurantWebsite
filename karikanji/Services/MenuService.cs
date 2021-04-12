using karikanji.DAL;
using karikanji.Models;
using karikanji.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace karikanji.Services
{
    public class MenuService
    {
        private readonly GenericRepository _genericRepository;
        public MenuService()
        {
            _genericRepository = new GenericRepository();
        }

        public List<Menu> GetMenuList()
        {

            var allMenus = _genericRepository.GetAll<Menu>().ToList();
            return allMenus;
        }

        public Menu Get(int id)
        {
            var menuModel = _genericRepository.Get<Menu>(a => a.MenuId == id);
            return menuModel;
        }
        public Menu Update(Menu menuModel)
        {
            var updatedResult = _genericRepository.Update(menuModel);
            _genericRepository.Save();
            return menuModel;
        }

        public Menu Add(Menu menuModel)
        {
            _genericRepository.Add(menuModel);
            _genericRepository.Save();
            return menuModel;
        }
        public void Delete(Menu menuModel)
        {
            _genericRepository.Delete(menuModel);
            _genericRepository.Save();
        }



    }
}