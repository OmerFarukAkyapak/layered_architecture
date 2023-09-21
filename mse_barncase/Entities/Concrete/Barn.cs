using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Barn : IEntity
    {
        [Key]
        public int FarmID { get; set; }
        public decimal FarmAmount { get; set; }
    }
}
