using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IBarnService
    {
        IDataResult<Barn> GetById(int farmId);
    }
}
