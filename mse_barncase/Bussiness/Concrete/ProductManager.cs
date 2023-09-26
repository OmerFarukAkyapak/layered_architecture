using Bussiness.Abstract;
using Bussiness.Constant;
using Core.Utilities.Result;
using DataAccess.Abstact;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Bussiness.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductID == productId));
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList().Where(p => p.ProductIsSold == false).ToList());
        }

        public IDataResult<List<Product>> GetListByTypes(int typeId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList(filter: p => p.ProductTypeID == typeId).ToList());
        }

        public IResult Update(int productid, bool issold)
        {
            var selectedProduct = _productDal.Get(p => p.ProductID == productid);
            selectedProduct.ProductIsSold = issold;
            _productDal.Update(selectedProduct);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
