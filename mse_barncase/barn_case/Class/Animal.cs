using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barn_case.Class
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int LifeSpan { get; set; }
        public bool IsAlive { get; set; }

        public Animal(int id,string species, string gender, int age, int lifeSpan)
        {
            AnimalId = id;
            Species = species;
            Gender = gender;
            Age = age;
            LifeSpan = lifeSpan;
            IsAlive = true;
        }

        public void UpdateLifeSpan()
        {        
            Age++;

            if (Age >= LifeSpan)
            {
                IsAlive = false;
            }
        }

        public virtual void ProduceProduct()
        {
            // Ürün üretim işlemleri burada yapılır.
            // Ürün tamamlandığında kasa para eklenmeli ve ürün satışa çıkmalıdır.

            // Ürün tamamlandığında kasa para eklemek için:
            int productValue = CalculateProductValue(); // Ürünün değerini hesaplayın.
            AddCashToCase(productValue);
        }

        private int CalculateProductValue()
        {
            // Ürünün değerini hesaplayan bir metod.
            // Ürün türüne ve miktarına bağlı olarak değeri hesaplanabilmeli.
            int result=0;
            return result;
        }

        private void AddCashToCase(int amount)
        {
            // Kasaya belirli bir miktar para ekleyen bir metod.
        }
    }
}
