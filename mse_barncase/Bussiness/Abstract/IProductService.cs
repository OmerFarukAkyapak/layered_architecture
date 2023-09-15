using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IProductService
    {
        IDataResult<Product> GetById(int ProductId);
        IDataResult<List<Product>> GetList();
        IDataResult<List<Product>> GetListByTypes(int typeId);
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);
    }
}
