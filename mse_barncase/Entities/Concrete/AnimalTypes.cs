using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class AnimalTypes : IEntity
    {
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        public int TypeLifeSpan { get; set; }
        public decimal TypePrice { get; set; }
    }
}
