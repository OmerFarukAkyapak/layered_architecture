using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barn_case.Class
{
    public class Farm
    {
        private List<Animal> animals; // Çiftlikteki hayvanları tutan liste
        private List<Product> products; // Çiftlikteki ürünleri tutan liste
        private decimal cash; // Çiftlik kasası

        public Farm()
        {
            animals = new List<Animal>();
            products = new List<Product>();
            cash = 0;
        }

        // Hayvan eklemek için bir metot
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        // Ürün eklemek için bir metot
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        // Ürünleri satmak ve kasa para eklemek için bir metot
        public void SellProduct(Product product)
        {
            products.Remove(product);
            cash += product.Price;
        }


    }
}
