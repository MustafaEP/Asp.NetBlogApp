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
    public class Message2Manager : IMessage2Service
    {
        IMessage2Dal message2Dal;

        public Message2Manager(IMessage2Dal message2Dal)
        {
            this.message2Dal = message2Dal;
        }

        public List<Message2> GetInBoxListByWriter(int id)
        {
            return message2Dal.GetListAll(x => x.ReceiverId == id);
        }

        public List<Message2> GetList()
        {
            return message2Dal.GetListAll();
        }

        public void TAdd(Message2 entity)
        {
            throw new NotImplementedException();
        }

    

        public void TDelete(Message2 entity)
        {
            throw new NotImplementedException();
        }

    

        public Message TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message2 entity)
        {
            throw new NotImplementedException();
        }


        List<Message2> IMessage2Service.GetInBoxListByWriter(string p)
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
