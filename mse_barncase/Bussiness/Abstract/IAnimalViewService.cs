using Core.Utilities.Result;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IAnimalViewService
    {
        IDataResult<AnimalsView> GetById(int animalId);
        IDataResult<List<AnimalsView>> GetListAll();
        IDataResult<List<AnimalsView>> GetListNotSold();
        IDataResult<List<AnimalsView>> GetListSold();
    }
}
