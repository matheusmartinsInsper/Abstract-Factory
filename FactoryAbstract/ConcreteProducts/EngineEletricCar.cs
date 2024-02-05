using FactoryAbstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAbstract.ConcreteProducts
{
    internal class EngineEletricCar: IEngineEletric
    {
        private double _potenciaTotal;
        private double _volumeTotal;
        public bool ligado { get; set; } = false;
        public int numBobina { get; set; }
        public double voltagemPorBobina { get; set; }
        public double resistenciaPorBobina { get; set; }
        public double potenciaTotal
        {
            get { return _potenciaTotal; }
            private set
            {
               _potenciaTotal = (((double)Math.Pow(voltagemPorBobina, 2)) * numBobina) * 0.9 / resistenciaPorBobina;
            }
        }
        public double volumeTotal { get { return _volumeTotal; } private set { _volumeTotal = value; } }
        public double rotacaoMaxima { get; set; }
        public double rotacao { get; set; } = 0;
        public double consumo { get; set; }
        public EngineEletricCar(double voltagemPorBobina, double resistenciaPorBobina, int numBobina)
        {
            this.numBobina = numBobina;
            this.resistenciaPorBobina = resistenciaPorBobina;
            this.voltagemPorBobina = voltagemPorBobina;
        }
        public void Acionar()
        {
            ligado = true;
            Console.WriteLine("Motor Acionado");
            while (ligado)
            {
                while (rotacao > 100)
                {
                    rotacao -= 10;
                    Console.WriteLine($"Rotação do motor: {rotacao}: status: Ligado");
                    Thread.Sleep(1000);
                }
                Console.WriteLine($"Rotação do motor: {rotacao}: status: Ligado \n Seleciona um aumento na rotação \n Digite close para desligar");
                string upRotation = Console.ReadLine();
                if (upRotation == "close")
                {
                    rotacao = 0;
                    Console.WriteLine($"Rotação do motor: {rotacao}: status: Desligado ");
                    ligado = false;
                    break;
                }
                Acelerar(double.Parse(upRotation));
            }
        }

        public void Desligar()
        {
            throw new NotImplementedException();
        }
        public void Acelerar(double Rotacao)
        {
            if (rotacao != null)
            {
                rotacao += Rotacao;
            }
            rotacao = rotacao;
        }
    }
}
