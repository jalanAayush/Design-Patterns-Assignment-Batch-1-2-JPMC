using FactoryDesignPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.ProductInterface
{
    interface ICarEngine
    {
        public void Start(ICarLight h);
    }
}
