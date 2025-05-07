using Foody.DataAccsessLayer.Abstract;
using Foody.DataAccsessLayer.Context;
using Foody.DataAccsessLayer.Repositories;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccsessLayer.EntityFramework
{
    public class EfAddressDal : GenericRepository<Address>, IAddressDal
    {
        public EfAddressDal(FoodyContext context) : base(context)
        {
        }
    }

}
