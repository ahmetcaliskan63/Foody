﻿using Foody.BusinessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrate
{
    public class SliderManager : ISliderService
    {
        private readonly ISliderService _sliderService;
        public SliderManager(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        public void TDelete(int id)
        {
            _sliderService.TDelete(id);
        }

        public List<Slider> TGetAll()
        {
            return _sliderService.TGetAll();
        }

        public Slider TGetById(int id)
        {
            return _sliderService.TGetById(id);
        }

        public void TInsert(Slider entity)
        {
           _sliderService.TInsert(entity);
        }

        public void TUpdate(Slider entity)
        {
            _sliderService.TUpdate(entity);
        }
    }
}
