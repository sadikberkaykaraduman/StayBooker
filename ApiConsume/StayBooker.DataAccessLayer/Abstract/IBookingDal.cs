using StayBooker.EntityLayer.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayBooker.DataAccessLayer.Abstract
{
    public interface IBookingDal : IGenericDal<Booking>
    {
        public int BookingCount();
        public List<Booking> GetLast6Booking();
    }
}
