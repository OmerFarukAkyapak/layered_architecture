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
        private Animal animalProps;

        public AnimalManager(IAnimalDal animalDal)
        {
            _animalDal = animalDal;
        }
        public IResult Add(int typeid,int genderid,int age)
        {
            // Buy a new animal
            Animal animal = new Animal();

            animal.AnimalTypeID = typeid;
            animal.AnimalGenderID = genderid;
            animal.AnimalAge = age;
            
            animal.AnimalIsAlive = true;
            animal.AnimalIsSold = false;

            _animalDal.Add(animal);
            return new SuccessResult(Messages.AnimalAdded); 
        }

        public IResult Delete(int animalid)
        {
            var selectedAnimal = _animalDal.Get(a => a.AnimalID == animalid);
            _animalDal.Delete(selectedAnimal);
            return new SuccessResult(Messages.AnimalDeleted);
        }

        public IDataResult<Animal> GetById(int animalId)
        {
            return new SuccessDataResult<Animal>(_animalDal.Get(a => a.AnimalID == animalId));
        }

        public IDataResult<List<Animal>> GetList()
        {
            return new SuccessDataResult<List<Animal>>(_animalDal.GetList().Where(a=>a.AnimalIsSold==false).ToList());
        }

        public IDataResult<List<Animal>> GetListByTypes(int typeId)
        {
            return new SuccessDataResult<List<Animal>>(_animalDal.GetList().Where(a => a.AnimalTypeID == typeId).ToList());
        }

        public IResult Update(int animalid,bool issold)
        {
            var selectedAnimal = _animalDal.Get(a => a.AnimalID == animalid);
            selectedAnimal.AnimalIsSold = issold;
            _animalDal.Update(selectedAnimal);
            return new SuccessResult(Messages.AnimalUpdated);
        }
    }
}
