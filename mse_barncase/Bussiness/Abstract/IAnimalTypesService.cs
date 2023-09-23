using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IAnimalTypesService
    {
        IDataResult<AnimalTypes>GetById(int typeId);
        IDataResult<decimal> GetByTypeAmount(string typeName);
        IDataResult<List<AnimalTypes>> GetList();
        IDataResult<List<string>> GetAnimalTypeNames();
    }
}
