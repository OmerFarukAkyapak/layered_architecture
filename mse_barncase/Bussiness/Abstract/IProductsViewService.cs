using Core.Utilities.Result;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IProductsViewService
    {
        IDataResult<ProductsView> GetById(int productId);
        IDataResult<List<ProductsView>> GetListAll();
        IDataResult<List<ProductsView>> GetListNotSold();
        IDataResult<List<ProductsView>> GetListSold();
    }
}
