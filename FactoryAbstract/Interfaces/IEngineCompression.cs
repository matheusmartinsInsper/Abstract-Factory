using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstract.Interfaces
{
    internal interface IEngineCompression
    {
        bool ligado { get; set; }
        int quantidadeDeStagios { get; set; }
        double aumentoDePresaoPorStagio { get; set; }
        double volumeCameraDeCombustao { get; set; }
        double potenciaTotal { get; }
        double rotacaoMaxima { get; }
        double consumo { get; }
        public void Acionar();
        public void Desligar();
        public void Acelerar(double rotacao);
    }
}
