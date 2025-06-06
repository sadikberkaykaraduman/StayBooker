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
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(Context context) : base(context)
        {
        }

        public List<Staff> GetLast4Staff()
        {
            var context = new Context();
            var value = context.Staffs.OrderByDescending(x => x.StaffId).Take(4).ToList();
            return value;
        }

        public int StaffCount()
        {
            var context = new Context();
            var value = context.Staffs.Count();
            return value;
        }
    }
}
