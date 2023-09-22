using Bussiness.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstact;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class AnimalTypesManager : IAnimalTypesService
    {
        private IAnimalTypeDal _animalTypes;
        public AnimalTypesManager(IAnimalTypeDal animalTypeDal)
        {
            _animalTypes = animalTypeDal;
        }
        public IDataResult<AnimalTypes> GetById(int typeId)
        {
            return new SuccessDataResult<AnimalTypes>(_animalTypes.Get(t => t.TypeID == typeId));
        }
    }
}
