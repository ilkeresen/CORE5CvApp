using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactMessageManager : IContactMessageService
    {
        IContactMessageDal _contactMessageDal;

        public ContactMessageManager(IContactMessageDal contactMessageDal)
        {
            _contactMessageDal = contactMessageDal;
        }

        public void TAdd(ContactMessage t)
        {
            _contactMessageDal.Insert(t);
        }

        public void TDelete(ContactMessage t)
        {
            _contactMessageDal.Delete(t);
        }

        public List<ContactMessage> TGetByFilter()
        {
            throw new NotImplementedException();
        }

        public ContactMessage TGetByID(int id)
        {
            return _contactMessageDal.GetByID(id);
        }

        public List<ContactMessage> TGetList()
        {
            return _contactMessageDal.GetList();
        }

        public void TUpdate(ContactMessage t)
        {
            _contactMessageDal.Update(t);
        }
    }
}
