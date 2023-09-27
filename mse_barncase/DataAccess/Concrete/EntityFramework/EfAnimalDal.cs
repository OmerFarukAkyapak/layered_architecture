using Core.DataAccess.EntityFramework;
using DataAccess.Abstact;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAnimalDal : EfEntityRepositoryBase<Animal, BarnContext>, IAnimalDal
    {  
        public IList<string> GetListByGender()
        {
            using (var context = new BarnContext())
            {
                var genderNames = context.Animal
                    .Select(a => a.AnimalGenders.GenderName)
                    .Distinct()
                    .ToList();

                return genderNames;
            }
        }
    }
}
