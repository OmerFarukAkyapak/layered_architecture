using Bussiness.Abstract;
using Bussiness.Constant;
using Core.Utilities.Result;
using DataAccess.Abstact;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness.Concrete
{
    public class AnimalManager : IAnimalService
    {
        private IAnimalDal _animalDal;

        public AnimalManager(IAnimalDal animalDal)
        {
            _animalDal = animalDal;
        }
        public IResult Add(Animal animal)
        {
            _animalDal.Add(animal);
            return new SuccessResult(Messages.AnimalAdded); 
        }

        public IResult Delete(Animal animal)
        {
            _animalDal.Delete(animal);
            return new SuccessResult(Messages.AnimalDeleted);
        }

        public IDataResult<Animal> GetById(int animalId)
        {
            return new SuccessDataResult<Animal>(_animalDal.Get(p => p.AnimalID == animalId));
        }

        public IDataResult<List<Animal>> GetList()
        {
            return new SuccessDataResult<List<Animal>>(_animalDal.GetList().ToList());
        }

        public IDataResult<List<Animal>> GetListByTypes(int typeId)
        {
            return new SuccessDataResult<List<Animal>>(_animalDal.GetList().Where(a => a.AnimalTypeID == typeId).ToList());
        }

        public IResult Update(Animal animal)
        {
            _animalDal.Update(animal);
            return new SuccessResult(Messages.AnimalUpdated);
        }
    }
}
