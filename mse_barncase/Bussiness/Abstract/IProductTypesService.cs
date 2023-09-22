using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IProductTypesService
    {
        IDataResult<ProductTypes> GetById(int typeId);
    }
}
