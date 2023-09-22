using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IAnimalService
    {
        IDataResult<Animal> GetById(int animalId);
        IDataResult<List<Animal>> GetList();
        IDataResult<List<Animal>> GetListByTypes(int typeId);
        //IDataResult<Animal> GetAmount();
        IResult Add(Animal animal);
        IResult Delete(Animal animal);
        IResult Update(Animal animal);
    }
}
