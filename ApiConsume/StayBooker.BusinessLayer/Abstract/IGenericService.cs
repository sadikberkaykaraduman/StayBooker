using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayBooker.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        public void TInsert(T entity);
        public void TUpdate(T entity);
        public void TDelete(T entity);
        public T TGetById(int id);
        public List<T> TGetAll();
    }
}
