using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstact
{
    public interface IAnimalDal : IEntityRepository<Animal>
    {
        IList<string> GetListByGender();
    }
}
