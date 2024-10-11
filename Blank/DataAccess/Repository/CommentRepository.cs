using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CommentRepository : IGenericDal<Comment>
    {
        public void Delete(Comment entity)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Comment entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
