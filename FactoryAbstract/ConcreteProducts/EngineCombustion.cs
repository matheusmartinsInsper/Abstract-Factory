using FactoryAbstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryAbstract.ConcreteProducts
{
    internal class EngineCombustion : IEngine
    {
        private TypesOfEngine _engineType;
        private double _potenciaTotal;
        private double _volumeTotal;
        public bool ligado { get; set; } = false;
        public TypesOfEngine EngineType { get { return _engineType; } set { _engineType = value; } }
        public int numBobina { get; set; }
        public double voltagemPorBobina { get; set; }
        public double resistenciaPorBobina { get; set; }
        public int numCilindros { get; set; }
        public double volumePorCilindro { get; set; }
        public double potenciaPorCilindro { get; set; }
        public double potenciaTotal { 
            get { return _potenciaTotal;}
            private set
            {
                if (_engineType == TypesOfEngine.Eletric)
                {
                    _potenciaTotal = (((double)Math.Pow(voltagemPorBobina, 2)) * numBobina)*0.9/ resistenciaPorBobina;
                }else if(_engineType == TypesOfEngine.Comnbustion)
                {
                    _potenciaTotal = numCilindros * potenciaPorCilindro*0.85;
                }else
                {
                    _potenciaTotal = 0;
                }
            }
        }
        public double volumeTotal { get { return _volumeTotal; } private set { _volumeTotal = value; } }
        public double rotacaoMaxima { get; set; }
        public double rotacao { get; set; } = 0;
        public double consumo { get; set; }
        public EngineCombustion(int numCilindros,double volumePorCilindro,double potenciaPorCilindro)
        {
            EngineType = TypesOfEngine.Comnbustion;
            this.numCilindros = numCilindros;
            this.volumePorCilindro = volumePorCilindro;
            this.potenciaPorCilindro = potenciaPorCilindro;
            _volumeTotal = numCilindros * volumePorCilindro;
            potenciaTotal = _potenciaTotal;
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
                Console.WriteLine($"Rotação do motor: {rotacao} | status: Ligado | Potencia: {_potenciaTotal}\n Seleciona um aumento na rotação \n Digite close para desligar");
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
        void Acelerar(double Rotacao)
        {
            if (rotacao != null)
            {
                rotacao += Rotacao;
            }
            rotacao = rotacao;
        }
    }
}
