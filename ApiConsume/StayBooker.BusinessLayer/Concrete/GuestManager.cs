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
    public class GuestManager : IGuestService
    {
        private readonly IGuestDal _guestDal;

        public GuestManager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }

        public void TDelete(Guest entity)
        {
            _guestDal.Delete(entity);
        }

        public List<Guest> TGetAll()
        {
            return _guestDal.GetAll();
        }

        public Guest TGetById(int id)
        {
            return _guestDal.GetById(id);
        }

        public int TGuestCount()
        {
            return _guestDal.GuestCount();
        }

        public void TInsert(Guest entity)
        {
            _guestDal.Insert(entity);
        }

        public void TUpdate(Guest entity)
        {
            _guestDal.Update(entity);
        }
    }
}
