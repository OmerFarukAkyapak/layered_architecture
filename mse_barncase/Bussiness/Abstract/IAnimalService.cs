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
        IDataResult<List<string>> GetListAnimalGendersName();
        IResult Add(int typeid, int genderid, int age);
        IResult Delete(int animalid);
        IResult Update(int animalid, bool issold);
    }
}
