using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IAnimalGendersService
    {
        IDataResult<AnimalGenders> GetById(int genderId);
        IDataResult<List<string>> GetAnimalGenderNames();
    }
}
