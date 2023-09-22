using Bussiness.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstact;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class AnimalGendersManager : IAnimalGendersService
    {
        private IAnimalGendersDal _animalGender;
        public AnimalGendersManager(IAnimalGendersDal animalGendersDal)
        {
            _animalGender = animalGendersDal;
        }
        public IDataResult<AnimalGenders> GetById(int genderId)
        {
            return new SuccessDataResult<AnimalGenders>(_animalGender.Get(g => g.GenderID == genderId));
        }
    }
}
