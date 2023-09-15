using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductID { get; set; }
        public int SourceAnimalID { get; set; }
        public int ProductTypeID { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ProductPrice { get; set; }
        public bool ProductIsSold { get; set; }

    }
}
