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
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;
        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TInsert(Service entity)
        {
            _serviceDal.Insert(entity);
        }

        public void TUpdate(Service entity)
        {
            _serviceDal.Update(entity);
        }

        public void TDelete(Service entity)
        {
            _serviceDal.Delete(entity);
        }

        public Service TGetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public List<Service> TGetAll()
        {
            return _serviceDal.GetAll();
        }
    }
}
