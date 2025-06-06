using StayBooker.EntityLayer.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayBooker.BusinessLayer.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        public int TBookingCount();
        public List<Booking> TGetLast6Booking();
    }
}
