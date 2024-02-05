using FactoryAbstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstract.ConcreteFactory
{
    internal class FactoryEngineAirPlanecs : IAbstractFactory
    {
        public IEngineCombustion createEngineCombustion()
        {
            throw new NotImplementedException();
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
