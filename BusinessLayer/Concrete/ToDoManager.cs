using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ToDoManager : IToDoService
    {
        IToDoDal _toDoDal;

        public ToDoManager(IToDoDal toDoDal)
        {
            _toDoDal = toDoDal;
        }

        public void TAdd(ToDo t)
        {
            _toDoDal.Insert(t);
        }

        public void TDelete(ToDo t)
        {
            _toDoDal.Delete(t);
        }

        public List<ToDo> TGetByFilter()
        {
            throw new NotImplementedException();
        }

        public ToDo TGetByID(int id)
        {
            return _toDoDal.GetByID(id);
        }

        public List<ToDo> TGetList()
        {
            return _toDoDal.GetList();
        }

        public void TUpdate(ToDo t)
        {
            _toDoDal.Update(t);
        }
    }
}
