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
    public class ResumeManager : IResumeService
    {
        IResumeDal _resumeDal;

        public ResumeManager(IResumeDal resumeDal)
        {
            _resumeDal = resumeDal;
        }

        public void TAdd(Resume t)
        {
            _resumeDal.Insert(t);
        }

        public void TDelete(Resume t)
        {
            _resumeDal.Delete(t);
        }

        public List<Resume> TGetByFilter()
        {
            throw new NotImplementedException();
        }

        public Resume TGetByID(int id)
        {
            return _resumeDal.GetByID(id);
        }

        public List<Resume> TGetList()
        {
            return _resumeDal.GetList();
        }

        public void TUpdate(Resume t)
        {
            _resumeDal.Update(t);
        }
    }
}
