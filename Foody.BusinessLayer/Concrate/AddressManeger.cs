using Foody.BusinessLayer.Abstract;
using Foody.DataAccsessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrate
{
    public class AddressManeger : IAddressService
    {
        private readonly IAddressDal _addressDal;
        public AddressManeger(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public void TDelete(int id)
        {
            _addressDal.Delete(id);
        }

        public List<Address> TGetAll()
        {
            return _addressDal.GetAll();
        }

        public Address TGetById(int id)
        {
            return _addressDal.GetById(id);
        }

        public void TInsert(Address entity)
        {
        _addressDal.Insert(entity);

        }

        public void TUpdate(Address entity)
        {
        _addressDal.Update(entity);
        }
        
    }
}
