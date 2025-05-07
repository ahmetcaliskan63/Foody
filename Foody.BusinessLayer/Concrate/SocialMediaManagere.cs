using Foody.BusinessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrate
{
    public class SocialMediaManagere : ISocialMediaService
    {
        private readonly ISocialMediaService _socialMediaService;
        public SocialMediaManagere(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }
        public void TDelete(int id)
        {
            _socialMediaService.TDelete(id);
        }

        public List<SocialMedia> TGetAll()
        {
            return _socialMediaService.TGetAll();
        }

        public SocialMedia TGetById(int id)
        {
           return _socialMediaService.TGetById(id);
        }

        public void TInsert(SocialMedia entity)
        {
            _socialMediaService.TInsert(entity);
        }

        public void TUpdate(SocialMedia entity)
        {
            _socialMediaService.TUpdate(entity);
        }
    }
}
