using FactoryAbstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstract.ConcreteFactory
{
    internal class NuclearFactory : IAbstractFactory
    {
        public IEngine createEngine()
        {
            throw new NotImplementedException();
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
