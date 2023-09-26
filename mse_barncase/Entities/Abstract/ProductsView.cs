using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Abstract
{
    public class ProductsView : IEntity
    {
        [Key]
        public int ProductID { get; set; }
        public int AnimalID { get; set; }
        public string ProductTypeName { get; set; }
        public decimal ProductTypePrice { get; set; }
        public bool ProductIsSold { get; set; }
    }
}
