using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class AnimalGenders : IEntity
    {
        [Key]
        public int GenderID { get; set; }
        public string GenderName { get; set; }
    }
}
