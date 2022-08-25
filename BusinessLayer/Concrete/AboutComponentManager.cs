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
    public class AboutComponentManager : IAboutComponentService
    {
        IAboutComponentDal _aboutComponentDal;

        public AboutComponentManager(IAboutComponentDal aboutComponentDal)
        {
            _aboutComponentDal = aboutComponentDal;
        }

        public void TAdd(AboutComponent t)
        {
            _aboutComponentDal.Insert(t);
        }

        public void TDelete(AboutComponent t)
        {
            _aboutComponentDal.Delete(t);
        }

        public List<AboutComponent> TGetByFilter()
        {
            throw new NotImplementedException();
        }

        public AboutComponent TGetByID(int id)
        {
            return _aboutComponentDal.GetByID(id);
        }

        public List<AboutComponent> TGetList()
        {
            return _aboutComponentDal.GetList();
        }

        public void TUpdate(AboutComponent t)
        {
            _aboutComponentDal.Update(t);
        }
    }
}
