using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MessageManager : IMessage2Service
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public List<Message> GetList()
        {
            return _messageDal.GetListAll();
        }

        public List<Message> GetInBoxListByWriter(string p)
        {
            return _messageDal.GetListAll(x => x.Receiver == p);
        }

     

  
        public Message TGetById(int id)
        {
            throw new NotImplementedException();
        }

     
        List<Message2> IMessage2Service.GetInBoxListByWriter(string p)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Message2 entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message2 entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message2 entity)
        {
            throw new NotImplementedException();
        }

        List<Message2> IGenericService<Message2>.GetList()
        {
            throw new NotImplementedException();
        }

        Message2 IGenericService<Message2>.TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
