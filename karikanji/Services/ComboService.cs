using karikanji.DAL;
using karikanji.Models;
using karikanji.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace karikanji.Services
{
    public class ComboService
    {
        private readonly GenericRepository _genericRepository;
        public ComboService()
        {
            _genericRepository = new GenericRepository();
        }
        public List<ComboViewModel> GetComboViewModels()
        {
            var menuModels = _genericRepository.GetAll<Menu>().Where(i => i.MenuType == Constants.MenuType.Combo).ToList();


            List<ComboViewModel> comboVmLists = new List<ComboViewModel>();
            foreach (var menu in menuModels)
            {
                comboVmLists.Add(new ComboViewModel
                {
                    MenuId = menu.MenuId,
                    ComboName = menu.Name,
                    ItemList = menu.Combos,
                    ComboPrice = menu.Price
                });
            }
            return comboVmLists;
        }
        public Combo GetModel(int id)
        {
            var comboModel = _genericRepository.Get<Combo>(a => a.ComboId == id);
            return comboModel;
        }

        public ComboItemViewModel GetViewModel(int id)
        {
            var comboModel = GetModel(id);
            return new ComboItemViewModel { 
                ComboId = comboModel.ComboId,
                Item = comboModel.Item
            };
        }

        public Combo Update(ComboItemViewModel comboItemViewModel)
        {
            var comboModel = GetModel(comboItemViewModel.ComboId);
            comboModel.Item = comboItemViewModel.Item;
            var updatedResult = _genericRepository.Update(comboModel);

            _genericRepository.Save();
            return comboModel;
        }

        public void Add(ComboItemViewModel comboItemViewModel)
        {
            var comboModel = new Combo {
                MenuId = comboItemViewModel.MenuId,
                Item = comboItemViewModel.Item,
            };
            _genericRepository.Add(comboModel);
            _genericRepository.Save();
        }
        public void Delete(Combo comboModel)
        {
            _genericRepository.Delete(comboModel);
            _genericRepository.Save();
        }

       
        
    }
}