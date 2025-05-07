using Foody.BusinessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrate
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureService _featureService;
        public FeatureManager(IFeatureService featureService)
        {
            _featureService = featureService;
        }
        public void TDelete(int id)
        {
            _featureService.TDelete(id);
        }

        public List<Feature> TGetAll()
        {
            return _featureService.TGetAll();
        }

        public Feature TGetById(int id)
        {
            return _featureService.TGetById(id);
        }

        public void TInsert(Feature entity)
        {
            _featureService.TInsert(entity);
        }

        public void TUpdate(Feature entity)
        {
            _featureService.TUpdate(entity);
        }
    }
}
