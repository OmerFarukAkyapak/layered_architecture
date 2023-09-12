using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barn_case.Class
{
    public interface IFarm
    {
        void AddAnimal(Animal animal);
        void AddProduct(Product product);
        void SellProduct(Product product);
    }
}
