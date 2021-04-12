using karikanji.DAL;
using karikanji.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace karikanji.Services
{
    public class ContactService
    {
         private readonly GenericRepository _genericRepository;
        public ContactService()
        {
            _genericRepository = new GenericRepository();
        }

        public Contact GetAll()
        {
            var contactModel = _genericRepository.GetAll<Contact>().First();
            return contactModel;
        }
        public Contact Get(int id)
        {
            var contactModel = _genericRepository.Get<Contact>(a => a.ContactId == id);
            return contactModel;
        }
        public Contact Update(Contact contactModel)
        {
            var updatedResult = _genericRepository.Update(contactModel);
            _genericRepository.Save();
            return contactModel;
        }

        //public Contact Add(Contact contactModel)
        //{
        //    _genericRepository.Add(contactModel);
        //    _genericRepository.Save();
        //    return contactModel;
        //}

        //public void Delete(Contact contactModel)
        //{
        //    _genericRepository.Delete(contactModel);
        //    _genericRepository.Save();
        //}

    }
}