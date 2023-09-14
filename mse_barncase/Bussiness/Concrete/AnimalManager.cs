using Bussiness.Abstract;
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
        public void Add(Animal animal)
        {
            _animalDal.Add(animal);
        }

        public void Delete(Animal animal)
        {
            _animalDal.Delete(animal);
        }

        public Animal GetById(int animalId)
        {       
            return _animalDal.Get(p=> p.AnimalID == animalId);
        }

        public List<Animal> GetList()
        {
            return _animalDal.GetList().ToList();
        }

        public List<Animal> GetListByTypes(int typeId)
        {
            return _animalDal.GetList(p => p.AnimalTypeID == typeId).ToList();
        }

        public void Update(Animal animal)
        {
            _animalDal.Update(animal);
        }
    }
}
