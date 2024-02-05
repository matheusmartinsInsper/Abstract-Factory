using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstract.Interfaces
{
    internal interface IAbstractFactory
    {
        public IEngineCombustion createEngineCombustion();
        public IEngineEletric createEngineEletric();
        public IEngineCompression createEngineCompression();
    }
}
