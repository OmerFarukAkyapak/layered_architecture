using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class ProductTypes : IEntity
    {
        [Key]
        public int ProductTypeID { get; set; }
        public string ProductTypeName { get; set; }
        public decimal ProductTypePrice { get; set; }
    }
}
