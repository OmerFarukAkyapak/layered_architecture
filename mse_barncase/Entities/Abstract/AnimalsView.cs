using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Abstract
{
    public class AnimalsView : IEntity
    {
        [Key]
        public int AnimalID { get; set; }
        public string TypeName { get; set; }
        public string GenderName { get; set; }
        public int AnimalAge { get; set; }
        public int TypeLifeSpan { get; set; }
        public decimal TypePrice { get; set; }
    }
}
