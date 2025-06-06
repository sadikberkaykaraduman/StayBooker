using StayBooker.EntityLayer.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayBooker.BusinessLayer.Abstract
{
    public interface IStaffService : IGenericService<Staff>
    {
        public int TStaffCount();
        public List<Staff> TGetLast4Staff();
    }
}
