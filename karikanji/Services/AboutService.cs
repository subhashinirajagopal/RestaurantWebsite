using karikanji.DAL;
using karikanji.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace karikanji.Services
{
    public class AboutService
    {
        private readonly GenericRepository _genericRepository;
        public AboutService()
        {
            _genericRepository = new GenericRepository();
        }

        public List<About> GetAll()
        {
            var aboutModels = _genericRepository.GetAll<About>();
            return aboutModels.ToList();
        }

        public About Get(int id)
        {
            var aboutModel = _genericRepository.Get<About>(a => a.AboutId == id);
            return aboutModel;
        }


        public About Update(About aboutModel)
        {
            var updatedResult = _genericRepository.Update(aboutModel);
            _genericRepository.Save();
            return aboutModel;
        }


    }
}