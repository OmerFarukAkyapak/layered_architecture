using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    public class Animal : IEntity
    {
        public int AnimalID { get; set; }
        public int AnimalTypeID { get; set; }
        public int AnimalGenderID { get; set; }
        public int AnimalAge { get; set; }   
        public bool AnimalIsSold { get; set; }
        public bool AnimalIsAlive { get; set; }

        [ForeignKey("AnimalGenderID")] 
        public AnimalGenders AnimalGenders { get; set; }
    }
}
