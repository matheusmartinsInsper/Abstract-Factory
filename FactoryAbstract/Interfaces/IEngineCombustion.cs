using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstract.Interfaces
{
    internal interface IEngineCombustion
    {
        bool ligado { get; set; }
        int numCilindros { get; set; }
        double volumePorCilindro { get; set; }
        double potenciaPorCilindro { get; set; }
        double potenciaTotal { get; }
        double volumeTotal { get; }
        double rotacao { get; set; }
        double rotacaoMaxima { get; }
        double consumo { get; }
        public void Acionar();
        public void Desligar();
        public void Acelerar(double rotacao);
    }
}
