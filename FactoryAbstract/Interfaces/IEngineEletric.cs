using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstract.Interfaces
{
    internal interface IEngineEletric
    {
        bool ligado { get; set; }
        int numBobina { get; set; }
        double voltagemPorBobina { get; set; }
        double resistenciaPorBobina { get; set; }
        double potenciaTotal { get;}
        double rotacaoMaxima { get; }
        double consumo { get; }
        public void Acionar();
        public void Desligar();
        public void Acelerar(double rotacao);
    }
}
