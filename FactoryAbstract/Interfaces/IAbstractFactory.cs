﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstract.Interfaces
{
    internal interface IAbstractFactory
    {
        public IEngine createEngine();
        public IEngineAirPlane createEngineAirPlane();
        public IEngineShip createEngineShip();
    }
}
