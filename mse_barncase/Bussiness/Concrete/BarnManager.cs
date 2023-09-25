using Bussiness.Abstract;
using Bussiness.Constant;
using Core.Utilities.Result;
using DataAccess.Abstact;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class BarnManager : IBarnService
    {
        private IBarnDal _barnDal;

        public BarnManager(IBarnDal barnDal)
        {
            _barnDal = barnDal;
        }

        public IDataResult<Barn> DecreaseAmount(decimal price)
        {
            var farmAmount = _barnDal.Get(f => f.FarmID == 1);

            if (farmAmount.FarmAmount >= price)
            {
                farmAmount.FarmAmount -= price;
                _barnDal.Update(farmAmount);
                return new SuccessDataResult<Barn>(data: farmAmount);
            }
            else
            {
                return new ErrorDataResult<Barn>("not enough");
            }
        }

        public IDataResult<Barn> GetAmount()
        {
            var farmAmount = _barnDal.Get(f => f.FarmID == 1);
            if (farmAmount != null)
            {
                return new SuccessDataResult<Barn>(data: farmAmount);

            }
            else
            {
                return new ErrorDataResult<Barn>("Barn miktarı bulunamadı.");
            }

        }

        public IDataResult<Barn> GetById(int farmId)
        {
            return new SuccessDataResult<Barn>(_barnDal.Get(f => f.FarmID == farmId));
        }

        public IResult IncreaceAmount(decimal price)
        {
            var farmAmount = _barnDal.Get(f => f.FarmID == 1);

            farmAmount.FarmAmount = farmAmount.FarmAmount + price;
            _barnDal.Update(farmAmount);
            return new SuccessResult(Messages.BarnUpdated);

        }
    }
}
