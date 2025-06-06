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
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessageDal _sendMessageDal;

        public SendMessageManager(ISendMessageDal sendMessageDal)
        {
            _sendMessageDal = sendMessageDal;
        }

        public void TDelete(SendMessage entity)
        {
            _sendMessageDal.Delete(entity);
        }

        public List<SendMessage> TGetAll()
        {
            return _sendMessageDal.GetAll();
        }

        public SendMessage TGetById(int id)
        {
            return _sendMessageDal.GetById(id);
        }

        public void TInsert(SendMessage entity)
        {
            _sendMessageDal.Insert(entity);
        }

        public void TUpdate(SendMessage entity)
        {
            _sendMessageDal.Update(entity);
        }
    }
}
