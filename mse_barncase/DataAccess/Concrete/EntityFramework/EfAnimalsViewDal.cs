using Core.DataAccess.EntityFramework;
using DataAccess.Abstact;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAnimalsViewDal : EfEntityRepositoryBase<AnimalsView, BarnContext>, IAnimalsViewDal
    {
    }
}
