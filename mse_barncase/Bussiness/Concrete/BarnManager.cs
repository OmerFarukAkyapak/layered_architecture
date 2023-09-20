using Bussiness.Abstract;
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

        public IDataResult<Barn> GetAmount()
        {
            Console.WriteLine("Get Amount basladi");
            var farmAmount = _barnDal.Get(f => f.FarmID == 1);
            Console.WriteLine(farmAmount.ToString());
            if (farmAmount != null)
            {
                return new SuccessDataResult<Barn>(farmAmount.FarmAmount.ToString());

            }
            else
            {
                return new ErrorDataResult<Barn>("Barn miktarı bulunamadı.");
            }

        }

        public IDataResult<Barn> GetById(int farmId)
        {
            return new SuccessDataResult<Barn>(_barnDal.Get(p => p.FarmID == farmId));
        }
    }
}
