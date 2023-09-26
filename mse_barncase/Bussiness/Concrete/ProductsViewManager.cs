using Bussiness.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstact;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness.Concrete
{
    public class ProductsViewManager : IProductsViewService
    {
        private IProductsViewDal _productsViewDal;
        public ProductsViewManager(IProductsViewDal productsViewDal)
        {
            _productsViewDal = productsViewDal;
        }
        public IDataResult<ProductsView> GetById(int productId)
        {
            return new SuccessDataResult<ProductsView>(_productsViewDal.Get(a => a.ProductID == productId));
        }

        public IDataResult<List<ProductsView>> GetListAll()
        {
            return new SuccessDataResult<List<ProductsView>>(_productsViewDal.GetList().ToList());
        }
        public IDataResult<List<ProductsView>> GetListSold()
        {
            return new SuccessDataResult<List<ProductsView>>(_productsViewDal.GetList().Where(p => p.ProductIsSold == true).ToList());
        }

        public IDataResult<List<ProductsView>> GetListNotSold()
        {
            return new SuccessDataResult<List<ProductsView>>(_productsViewDal.GetList().Where(p=>p.ProductIsSold==false).ToList());
        }
    }
}
