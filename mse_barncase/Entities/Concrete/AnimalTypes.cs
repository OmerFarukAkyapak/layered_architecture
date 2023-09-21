using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class AnimalTypes : IEntity
    {
        [Key]
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        public int TypeLifeSpan { get; set; }
        public decimal TypePrice { get; set; }
    }
}
