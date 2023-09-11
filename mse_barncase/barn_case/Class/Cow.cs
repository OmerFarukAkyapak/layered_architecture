using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barn_case.Class
{
    public class Cow : Animal
    {
        public Cow(int id, string species, string gender, int age, int lifeSpan) : base(id, species, gender, age, lifeSpan)
        {
        }
        public Cow(int id,string gender, int age) : base(id,"Cow", gender, age, 5) // İneklerin yaşam süresi 5 yıl olarak kabul edelim.
        {
        }

        public override void ProduceProduct()
        {
            // İnekler süt üretir, bu metot içinde süt üretim işlemleri yapılır.
            // Ürün tamamlandığında kasa para eklenmeli ve süt satılabilir hale gelmelidir.
        }
    }
}
