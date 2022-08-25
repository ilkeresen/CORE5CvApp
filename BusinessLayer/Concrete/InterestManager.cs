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
    public class InterestManager : IInterestService
    {
        IInterestDal _ınterestDal;

        public InterestManager(IInterestDal ınterestDal)
        {
            _ınterestDal = ınterestDal;
        }

        public void TAdd(Interest t)
        {
            _ınterestDal.Insert(t);
        }

        public void TDelete(Interest t)
        {
            _ınterestDal.Delete(t);
        }

        public List<Interest> TGetByFilter()
        {
            throw new NotImplementedException();
        }

        public Interest TGetByID(int id)
        {
            return _ınterestDal.GetByID(id);
        }

        public List<Interest> TGetList()
        {
            return _ınterestDal.GetList();
        }

        public void TUpdate(Interest t)
        {
            _ınterestDal.Update(t);
        }
    }
}
