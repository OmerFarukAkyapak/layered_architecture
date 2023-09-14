using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Barn : IEntity
    {
        public int FarmID { get; set; }
        public decimal FarmAmount { get; set; }
    }
}
