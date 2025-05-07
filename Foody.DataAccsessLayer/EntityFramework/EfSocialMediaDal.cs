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
    public class EfSocialMediaDal:GenericRepository<SocialMedia>, ISocialMediaDal
    {
        public EfSocialMediaDal(FoodyContext context) : base(context)
        {
        }
    }

}
