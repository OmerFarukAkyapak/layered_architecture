using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IAnimalService
    {
        Animal GetById(int animalId);
        List<Animal> GetList();
        List<Animal> GetListByTypes(int typeId);
        void Add(Animal animal);
        void Delete(Animal animal);
        void Update(Animal animal);
    }
}
