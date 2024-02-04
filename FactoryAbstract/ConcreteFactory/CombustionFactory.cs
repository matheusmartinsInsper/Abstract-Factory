using FactoryAbstract.ConcreteProducts;
using FactoryAbstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstract.ConcreteFactory
{
    internal class CombustionFactory : IAbstractFactory
    {
        public IEngine createEngine()
        {
            return new EngineCombustion(4,250.00,50.00);
        }

        public IEngineAirPlane createEngineAirPlane()
        {
            throw new NotImplementedException();
        }

        public IEngineShip createEngineShip()
        {
            throw new NotImplementedException();
        }
    }
}
