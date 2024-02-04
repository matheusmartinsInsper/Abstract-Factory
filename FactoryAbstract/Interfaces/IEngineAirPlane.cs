using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstract.Interfaces
{
    internal interface IEngineAirPlane
    {
        TypesOfEngine EngineType { get; set; }
        int numCilindros { get; set; }
        double volumePorCilindro { get; set; }
        double potenciaPorCilindro { get; set; }
        double potenciaTotal { get; set; }
        int quantidadeDeStagios { get; set; }
        double volumeCameraDeCombustao { get; set; }
        double rotacaoMaxima { get; set; }
        double consumo { get; set; }

        public void Acionar();
        public void Desligar();
    }
}
