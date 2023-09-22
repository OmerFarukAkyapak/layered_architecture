using Bussiness.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstact;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class ProductTypesManager : IProductTypesService
    {
        private IProductTypesDal _productTypes;
        public ProductTypesManager(IProductTypesDal productTypes)
        {
            _productTypes = productTypes;
        }
        public IDataResult<ProductTypes> GetById(int typeId)
        {
            return new SuccessDataResult<ProductTypes>(_productTypes.Get(t => t.ProductTypeID == typeId));
        }

    }
}
