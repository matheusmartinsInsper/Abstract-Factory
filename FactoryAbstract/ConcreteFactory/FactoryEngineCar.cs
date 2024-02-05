using FactoryAbstract.ConcreteProducts;
using FactoryAbstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstract.ConcreteFactory
{
    internal class FactoryEngineCar : IAbstractFactory
    {
        public IEngineCombustion createEngineCombustion()
        {
            return new EngineCombustionCar(5, 250.00, 40.00);
        }

        public IEngineCompression createEngineCompression()
        {
            throw new NotImplementedException();
        }

        public IEngineEletric createEngineEletric()
        {
            throw new NotImplementedException();
        }
    }
}
