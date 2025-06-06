using StayBooker.EntityLayer.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayBooker.DataAccessLayer.Abstract
{
    public interface IStaffDal : IGenericDal<Staff>
    {
        public int StaffCount();
        public List<Staff> GetLast4Staff();
    }
}
