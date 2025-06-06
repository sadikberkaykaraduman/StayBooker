﻿using StayBooker.BusinessLayer.Abstract;
using StayBooker.DataAccessLayer.Abstract;
using StayBooker.EntityLayer.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayBooker.BusinessLayer.Concrete
{
    public class MessageCategoryManager : IMessageCategoryService
    {
        private readonly IMessageCategoryDal _messageCategoryDal;

        public MessageCategoryManager(IMessageCategoryDal messageCategoryDal)
        {
            _messageCategoryDal = messageCategoryDal;
        }

        public void TDelete(MessageCategory entity)
        {
            _messageCategoryDal.Delete(entity);
        }

        public List<MessageCategory> TGetAll()
        {
            return _messageCategoryDal.GetAll();
        }

        public MessageCategory TGetById(int id)
        {
            return _messageCategoryDal.GetById(id);
        }

        public void TInsert(MessageCategory entity)
        {
            _messageCategoryDal.Insert(entity);
        }

        public void TUpdate(MessageCategory entity)
        {
            _messageCategoryDal.Update(entity);
        }
    }
}
