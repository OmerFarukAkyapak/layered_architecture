using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int LifeSpan { get; set; }
        public bool IsAlive { get; set; }

    }
}
