using Bussiness.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstact;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness.Concrete
{
    public class AnimalViewManager : IAnimalViewService
    {
        private IAnimalsViewDal _animals;
        public AnimalViewManager(IAnimalsViewDal animal)
        {
            _animals = animal;
        }
        public IDataResult<AnimalsView> GetById(int animalId)
        {
            return new SuccessDataResult<AnimalsView>(_animals.Get(a => a.AnimalID == animalId));
        }

        public IDataResult<List<AnimalsView>> GetListAll()
        {
            return new SuccessDataResult<List<AnimalsView>>(_animals.GetList().ToList());
        }

        public IDataResult<List<AnimalsView>> GetListNotSold()
        {
            return new SuccessDataResult<List<AnimalsView>>(_animals.GetList().Where(a=>a.AnimalIsSold==false).ToList());
        }
    }
}
