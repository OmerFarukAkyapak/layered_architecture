using Bussiness.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstact;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public IDataResult<List<AnimalTypes>> GetList()
        {
            return new SuccessDataResult<List<AnimalTypes>>(_animalTypes.GetList().ToList());
        }
        public IDataResult<List<string>> GetAnimalTypeNames()
        {
            var animalTypes = _animalTypes.GetList().Select(at => at.TypeName).ToList();
            return new SuccessDataResult<List<string>>(animalTypes);
        }

        public IDataResult<decimal> GetByTypeAmount(string typeName)
        {
            
            var animalType = _animalTypes.Get(t => t.TypeName == typeName);

            decimal typeAmount = animalType.TypePrice;

            return new SuccessDataResult<decimal>(typeAmount);

        }
    }
}
