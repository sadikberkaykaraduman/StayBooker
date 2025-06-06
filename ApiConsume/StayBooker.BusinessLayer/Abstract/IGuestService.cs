using StayBooker.EntityLayer.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayBooker.BusinessLayer.Abstract
{
    public interface IGuestService : IGenericService<Guest>
    {
        public int TGuestCount();
    }
}
