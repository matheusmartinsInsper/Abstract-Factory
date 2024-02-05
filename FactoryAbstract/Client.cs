using FactoryAbstract.ConcreteFactory;
using FactoryAbstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstract
{
    internal class Client
    {
        public void Main () 
        {
            IAbstractFactory factory1 = new FactoryEngineCar();
            IEngineCombustion engeni1 = factory1.createEngineCombustion();
            engeni1.Acionar();
        }
    }
}
