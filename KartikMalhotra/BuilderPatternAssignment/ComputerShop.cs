using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPatternAssignment.Builder;

namespace BuilderPatternAssignment.Shop
{
    abstract class ComputerShop
    {
        abstract public void Construct(ComputerBuilder computerbuilder);
    }
}
