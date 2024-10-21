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
    public class NatificationManager : INatificationService
    {
        INatificationDal _natificationDal;
        public NatificationManager(INatificationDal natificationDal)
        {
            _natificationDal = natificationDal;
        }

        public List<Natification> GetList()
        {
            return _natificationDal.GetListAll();
        }

        public void TAdd(Natification entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Natification entity)
        {
            throw new NotImplementedException();
        }

        public Natification TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Natification entity)
        {
            throw new NotImplementedException();
        }
    }
}
