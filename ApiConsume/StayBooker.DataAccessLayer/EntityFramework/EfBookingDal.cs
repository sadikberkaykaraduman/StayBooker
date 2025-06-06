using StayBooker.DataAccessLayer.Abstract;
using StayBooker.DataAccessLayer.Concrete;
using StayBooker.DataAccessLayer.Repositories;
using StayBooker.EntityLayer.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayBooker.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(Context context) : base(context)
        {
        }

        public int BookingCount()
        {
            var context = new Context();
            var value = context.Bookings.Count();
            return value;
        }

        public List<Booking> GetLast6Booking()
        {
            var context = new Context();
            var value = context.Bookings.OrderByDescending(x => x.BookingId).Take(6).ToList();
            return value;
        }
    }
}
