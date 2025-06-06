using StayBooker.BusinessLayer.Abstract;
using StayBooker.DataAccessLayer.Abstract;
using StayBooker.EntityLayer.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayBooker.BusinessLayer.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void TDelete(Staff entity)
        {
            _staffDal.Delete(entity);
        }

        public List<Staff> TGetAll()
        {
            return _staffDal.GetAll();
        }

        public Staff TGetById(int id)
        {
            return _staffDal.GetById(id);
        }

        public List<Staff> TGetLast4Staff()
        {
            return _staffDal.GetLast4Staff();
        }

        public void TInsert(Staff entity)
        {
            _staffDal.Insert(entity);
        }

        public int TStaffCount()
        {
            return _staffDal.StaffCount();
        }

        public void TUpdate(Staff entity)
        {
            _staffDal.Update(entity);
        }
    }
}
