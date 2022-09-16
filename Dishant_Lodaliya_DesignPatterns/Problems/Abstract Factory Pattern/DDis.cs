using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishant_Lodaliya_DesignPatterns.Problems.Abstract_Factory_Pattern.Interface
{
    class DDis : ICarEngine
    {
        public void Start(ICarLight h)
        {

            Console.WriteLine(GetType().Name + " Engine & " + h.GetType().Name);
        }
    }
}
