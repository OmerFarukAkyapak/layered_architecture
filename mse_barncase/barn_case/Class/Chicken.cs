using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barn_case.Class
{
    public class Chicken : Animal
    {
        public Chicken(int id, string species, string gender, int age, int lifeSpan) : base(id, species, gender, age, lifeSpan)
        {
        }

        public Chicken(int id,string gender, int age) : base(id,"Chicken", gender, age, 2) // Tavukların yaşam süresi 2 yıl olarak kabul edelim.
        { 
        }

        public override void ProduceProduct()
        {
            // Tavuklar yumurta üretir, bu metot içinde yumurta üretim işlemleri yapılır.
            // Ürün tamamlandığında kasa para eklenmeli ve yumurta satılabilir hale gelmelidir.
        }

    }
}
