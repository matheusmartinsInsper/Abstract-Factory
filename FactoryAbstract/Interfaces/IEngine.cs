using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstract.Interfaces
{
    internal interface IEngine
    {
        bool ligado { get; set; }
        TypesOfEngine EngineType { get; protected set; }
        int numBobina { get; set; }
        double voltagemPorBobina { get; set; }
        double resistenciaPorBobina { get; set; }
        int numCilindros { get; set; }
        double volumePorCilindro { get; set; }
        double potenciaPorCilindro { get; set; }
        double potenciaTotal { get; }
        double volumeTotal { get; }
        double rotacao { get; }
        double rotacaoMaxima { get; }
        double consumo { get; }
        public void Acionar();
        public void Desligar();
    }
}
